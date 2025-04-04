using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SerialMakerBlazor.Data;
using SerialMakerBlazor.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerialMakerBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SignInManager<Data.AppUser> _signInManager;
        private readonly Repositories.IGenericRepo<Data.AppUser> _userRepo;
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
      
        public AccountController(SignInManager<AppUser> signInManager, IGenericRepo<AppUser> userRepo)
        {
            _signInManager = signInManager;
            _userRepo = userRepo;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> OnPostAsync(Pages.Login.LoginModel loginModel,string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var rtv = _userRepo.GetAll(a => a.UserName.Equals(loginModel.Email))?.FirstOrDefault();
                if (rtv != null && rtv.IsStop == true)
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    throw new Exception("Invalid login attempt. Please try again.");
                }
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    //_logger.LogInformation("User logged in.");
                    if (!returnUrl.StartsWith("/"))
                        returnUrl = "~/" + returnUrl;
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = loginModel.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    //_logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    throw new Exception("Invalid login attempt. Please try again.");
                }
            }

            // If we got this far, something failed, redisplay form
            return Ok();
        }
        [Route("LoginOld")]
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromBody] Pages.Login.LoginModel loginModel)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(
               loginModel.Email,
               loginModel.Password,
               loginModel.RememberMe,
               lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var rtv =await _signInManager.UserManager.FindByNameAsync(loginModel.Email);
                    return Ok(rtv);
                }
                else
                {
                    // Set an error message for invalid login attempts
                    throw new Exception("Invalid login attempt. Please try again.");
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        [Authorize]
        [HttpGet("Logout")]
        public async Task<IActionResult> LogOut(string returnUrl)
        {
            try
            {
                await _signInManager.SignOutAsync();
               // _logger.LogInformation("User logged out.");
                if (returnUrl != null)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    // Get the base URL
                    var request = HttpContext.Request;
                    var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";
                   // _loggerService.AddErrorLog(baseUrl);
                    // Redirect to the base URL
                    return Redirect(baseUrl);

                    //return RedirectToRoute("Identity/Account/Login");
                }
            }
            catch (Exception ex)
            {
               // _loggerService.AddErrorLog(ex);
                return LocalRedirect("~/");
            }

        }
    }
}
