using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace prac5.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            if (Username == "student" && Password == "1234")
            {
                HttpContext.Session.SetString("Username", Username);
                return RedirectToPage("Default");
            }

            Message = "Invalid Login";
            return Page();
        }
    }
}