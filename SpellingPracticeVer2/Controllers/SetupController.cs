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
            var model = new SpellingSet {
                words = new List<string> { "exception", "thrown", "system"}
            };

            return View(model);
        }
    }
}