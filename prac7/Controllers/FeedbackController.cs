using Microsoft.AspNetCore.Mvc;
using prac7.Models;

namespace prac7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<StudentFeedback> feedbackList = new List<StudentFeedback>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentFeedback fb)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(fb);
                return RedirectToAction("List");
            }
            return View(fb);
        }

        public IActionResult List()
        {
            return View(feedbackList);
        }
    }
}