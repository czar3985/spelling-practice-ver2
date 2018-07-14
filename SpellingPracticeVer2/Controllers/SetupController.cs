using SpellingPracticeVer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Index()
        {
            // Get the words from a text file
            string path = Server.MapPath(@"~/App_Data/words.txt");
            var fileContent = System.IO.File.ReadAllText(path);

            var model = new SpellingSet {
                words = new List<string> {}
            };

            model.words = fileContent.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            ).ToList();

            return View(model);
        }

        public ActionResult StartTest()
        {
            return RedirectToAction("Index", "Practice");
        }
    }
}