using KonusarakOgren.Core.DT0s.Users;
using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace KonusarakOgren.WepApp.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly UserManager<ApiUser> _userManager;

        public LoginModel(UserManager<ApiUser> userManager)
        {
            _userManager = userManager;
        }

        [BindProperty]
        public Credential Credential { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(Credential credential)
        {
            var _user = await _userManager.FindByNameAsync(credential.UserName);
            bool isValidCredentials = await _userManager.CheckPasswordAsync(_user, Credential.Password);
            if (!isValidCredentials)
            {
                return default;
            }
            return RedirectToPage("/Index");
        }
    }

    public class Credential
    {

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

