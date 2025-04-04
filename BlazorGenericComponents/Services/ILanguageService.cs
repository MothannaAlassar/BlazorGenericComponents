using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorGenericComponents.Services
{
    public interface ILanguageService
    {
        Task<string> GetSelectedLanguageAsync();
        Task SetSelectedLanguageAsync(string language);
        Task<Dictionary<string, string>> LoadLanguageAsync(string language);
        Task LoadLanguageFileAsync(string language);
        string GetTranslation(string key);
    }
}
