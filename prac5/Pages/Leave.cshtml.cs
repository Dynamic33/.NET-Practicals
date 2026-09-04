using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace prac5.Pages
{
    public class LeaveModel : PageModel
    {
        [BindProperty]
        public LeaveInputModel Input { get; set; } = new();

        public string LeaveDateDisplay { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public bool IsSubmitted { get; set; }

        public IActionResult OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Username")))
                return RedirectToPage("Login");

            LeaveDateDisplay = HttpContext.Session.GetString("LeaveDate") ?? DateTime.Today.ToShortDateString();

            if (Request.Cookies["StudentName"] != null)
                Input.Name = Request.Cookies["StudentName"]!;

            return Page();
        }

        public IActionResult OnPost()
        {
            LeaveDateDisplay = HttpContext.Session.GetString("LeaveDate") ?? DateTime.Today.ToShortDateString();

            if (!ModelState.IsValid) return Page();

            HttpContext.Session.SetString("Name", Input.Name);
            HttpContext.Session.SetString("Enrollment", Input.Enrollment);
            HttpContext.Session.SetString("LeaveType", Input.LeaveType);
            HttpContext.Session.SetString("Reason", Input.Reason);

            Response.Cookies.Append("StudentName", Input.Name, new CookieOptions { Expires = DateTime.Now.AddDays(7) });

            Message = "Leave Applied Successfully";
            IsSubmitted = true;

            return Page();
        }

        public class LeaveInputModel
        {
            [Required(ErrorMessage = "Enter Name")]
            public string Name { get; set; } = string.Empty;

            [Required(ErrorMessage = "Enter Enrollment No.")]
            public string Enrollment { get; set; } = string.Empty;

            [Required(ErrorMessage = "Select Leave")]
            public string LeaveType { get; set; } = string.Empty;

            [Required(ErrorMessage = "Enter Reason")]
            public string Reason { get; set; } = string.Empty;
        }
    }
}