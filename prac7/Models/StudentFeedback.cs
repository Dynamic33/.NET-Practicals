using System.ComponentModel.DataAnnotations;

namespace prac7.Models
{
    public class StudentFeedback
    {
        [Required(ErrorMessage = "Enrollment Number is required")]
        [Display(Name = "Enrollment Number")]
        public string EnrollmentNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Student Name is required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10")]
        public int Rating { get; set; }

        public string Comments { get; set; } = string.Empty;
    }
}