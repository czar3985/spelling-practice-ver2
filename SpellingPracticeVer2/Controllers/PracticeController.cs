using SpellingPracticeVer2.Models;
using SpellingPracticeVer2.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            // Get the words from a text file
            var listService = new ListService();
            var words = listService.GetWords();
            var model = new SpellingViewModel();

            model.Word1 = "";
            model.Word2 = "";
            model.Word3 = "";
            model.Word4 = "";
            model.Word5 = "";
            model.Word6 = "";
            model.Word7 = "";
            model.Word8 = "";
            model.Word9 = "";
            model.Word10 = "";

            if (words[0] != null)
                model.Word1 = words[0];
            if (words[1] != null)
                model.Word2 = words[1];
            if (words[2] != null)
                model.Word3 = words[2];
            if (words[3] != null)
                model.Word4 = words[3];
            if (words[4] != null)
                model.Word5 = words[4];
            if (words[5] != null)
                model.Word6 = words[5];
            if (words[6] != null)
                model.Word7 = words[6];
            if (words[7] != null)
                model.Word8 = words[7];
            if (words[8] != null)
                model.Word9 = words[8];
            if (words[9] != null)
                model.Word10 = words[9];

            return View(model);
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