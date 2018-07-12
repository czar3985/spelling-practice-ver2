using SpellingPracticeVer2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SpellingPracticeVer2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UsePrevious()
        {
            return RedirectToAction("Index", "Setup");
        }

        [HttpPost]
        public ActionResult NewWords(SpellingViewModel model)
        {
            // Update words file
            string path = Server.MapPath(@"~/App_Data/words.txt");

            StringBuilder fileContent = new StringBuilder();
            fileContent.AppendLine(model.Word1)
                        .AppendLine(model.Word2)
                        .AppendLine(model.Word3)
                        .AppendLine(model.Word4)
                        .AppendLine(model.Word5)
                        .AppendLine(model.Word6)
                        .AppendLine(model.Word7)
                        .AppendLine(model.Word8)
                        .AppendLine(model.Word9)
                        .AppendLine(model.Word10);

            System.IO.File.WriteAllText(path, fileContent.ToString());

            return RedirectToAction("Index", "Setup");
        }
    }
}