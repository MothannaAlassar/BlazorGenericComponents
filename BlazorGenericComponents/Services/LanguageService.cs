using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;
        private const string _baseAddress = "http://localhost/NasServerApp/";// "https://localhost:44385/";
        private const string LocalStorageKey = "selectedLanguage";
        private readonly ILoggerService _loggerService;

        public LanguageService(HttpClient httpClient, IJSRuntime jsRuntime, ILoggerService loggerService)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
            _loggerService = loggerService;
        }

        async Task<string> ILanguageService.GetSelectedLanguageAsync()
        {
            try
            {
                return await _jsRuntime.InvokeAsync<string>("localStorage.getItem", LocalStorageKey);
            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
                //throw new System.Exception("this exception because i call javascript befor render page");
                return "en";
            }

        }

        async Task ILanguageService.SetSelectedLanguageAsync(string language)
        {
            try
            {
                await _jsRuntime.InvokeVoidAsync("localStorage.setItem", LocalStorageKey, language);
            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
            }

        }

        async Task<Dictionary<string, string>> ILanguageService.LoadLanguageAsync(string language)
        {
            //var translations = await _httpClient.GetFromJsonAsync<Dictionary<string, string>>($"locales/{language}.json");
            //return translations ?? new Dictionary<string, string>();
            // Use the base address to construct the request URL
            var translations = await _httpClient.GetFromJsonAsync<Dictionary<string, string>>($"{_baseAddress}locales/{language}.json");
            return translations ?? new Dictionary<string, string>();
        }
        private readonly string _languageFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "locales");
        private Dictionary<string, string> _translations = new();
        private string _currentLanguage = "en";

        async Task ILanguageService.LoadLanguageFileAsync(string language)
        {
            try
            {
                _currentLanguage = language;
                var filePath = Path.Combine(_languageFolder, $"{language}.json");

                if (File.Exists(filePath))
                {
                    var json = await File.ReadAllTextAsync(filePath);
                    _translations = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
                }
            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
            }

        }
        string ILanguageService.GetTranslation(string key)
        {
            try
            {
                //return _translations.TryGetValue(key, out var value) ? value : key;
                if (_translations.TryGetValue(key, out var value))
                {
                    return value; // Return the found translation
                }
                else
                {
                    // Key not found, add it with the default value (e.g., the key itself)
                    _translations[key] = key; // You may want to customize the default value
                    AppendTranslationsToFile(key); // Write the updated translations back to the file
                    return key; // Return the key as default
                }
            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
                return key;
            }
        }
        private Dictionary<string, string> ReadAllData()
        {
            try
            {

                var filePath = Path.Combine(_languageFolder, $"{_currentLanguage}.json");

                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    var rtv = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
                    return rtv;
                }
                return null;
            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
                return null;
            }
        }
        private void AppendTranslationsToFile(string key)
        {
            try
            {
                var filePath = Path.Combine(_languageFolder, $"{_currentLanguage}.json");

                if (File.Exists(filePath))
                {
                    var jsonRead = File.ReadAllText(filePath);
                    var rtv = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonRead) ?? new Dictionary<string, string>();
                    if (rtv == null || rtv.Count <= 0)
                        rtv = new Dictionary<string, string>();
                    if (rtv != null)
                    {
                        if (!rtv.TryGetValue(key, out var value))
                        {
                            // Key not found, add it with the default value (e.g., the key itself)
                            rtv[key] = key; // You may want to customize the default value
                            //_translations[key] = key;
                            var json = JsonSerializer.Serialize(rtv, new JsonSerializerOptions { WriteIndented = true });
                            File.WriteAllText(filePath, json, Encoding.UTF8);
                        }
                    }
                }



            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
            }
        }
        private void WriteTranslationsToFile()
        {
            try
            {
                var filePath = Path.Combine(_languageFolder, $"{_currentLanguage}.json");
                var json = JsonSerializer.Serialize(_translations, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

            }
            catch (System.Exception ex)
            {
                _loggerService.AddErrorLog(ex);
            }
        }

    }
}
