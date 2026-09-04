using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace prac5.Pages
{
    public class DefaultModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Please select a date.")]
        [DataType(DataType.Date)]
        public DateTime SelectedDate { get; set; } = DateTime.Today;

        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                return RedirectToPage("Login");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            HttpContext.Session.SetString("LeaveDate", SelectedDate.ToShortDateString());
            return RedirectToPage("Leave");
        }
    }
}