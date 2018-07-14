using SpellingPracticeVer2.Models;
using SpellingPracticeVer2.Services;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Index()
        {
            var listService = new ListService();

            // Get the words from a text file
            var model = new SpellingSet {
                words = listService.GetWords()
            };

            return View(model);
        }

        public ActionResult StartTest()
        {
            return RedirectToAction("Index", "Practice");
        }
    }
}