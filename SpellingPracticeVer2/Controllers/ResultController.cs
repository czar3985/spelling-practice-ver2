using SpellingPracticeVer2.Models;
using SpellingPracticeVer2.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class ResultController : Controller
    {
        // GET: Result
        public ActionResult Index()
        {
            var listService = new ListService();

            var model = new DataViewModel
            {
                words = listService.GetWords(),
                answers = (List<string>)TempData["answerList"]
            };

            return View(model);
        }
    }
}