using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace prac4.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; } = new InputModel();

        public bool IsRegistered { get; set; } = false;

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Registration logic (e.g., saving to a database) goes here

            IsRegistered = true;
            return Page();
        }

        public class InputModel
        {
            [Required(ErrorMessage = "Name is required.")]
            [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
            public string Name { get; set; } = string.Empty;

            [Required(ErrorMessage = "Enrollment number is required.")]
            [Display(Name = "Enrollment No.")]
            public string Enrollment { get; set; } = string.Empty;

            [Required(ErrorMessage = "GR number is required.")]
            [Display(Name = "GR No.")]
            public string GR { get; set; } = string.Empty;

            [Required(ErrorMessage = "Please select a gender.")]
            public string Gender { get; set; } = string.Empty;

            [Required(ErrorMessage = "Please select an event.")]
            [Display(Name = "Event")]
            public string SelectedEvent { get; set; } = string.Empty;

            [Required(ErrorMessage = "Email address is required.")]
            [EmailAddress(ErrorMessage = "Invalid email address format.")]
            public string Email { get; set; } = string.Empty;
        }
    }
}