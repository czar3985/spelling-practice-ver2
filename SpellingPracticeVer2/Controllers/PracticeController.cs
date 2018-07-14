using SpellingPracticeVer2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SpellingViewModel model)
        {
            var list = new List<string> { };
            list.Add(model.Answer1);
            list.Add(model.Answer2);
            list.Add(model.Answer3);
            list.Add(model.Answer4);
            list.Add(model.Answer5);
            list.Add(model.Answer6);
            list.Add(model.Answer7);
            list.Add(model.Answer8);
            list.Add(model.Answer9);
            list.Add(model.Answer10);

            TempData["answerList"] = list;

            return RedirectToAction("Index", "Result");
        }
    }
}