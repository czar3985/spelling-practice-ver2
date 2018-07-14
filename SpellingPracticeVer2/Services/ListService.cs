using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpellingPracticeVer2.Services
{
    public class ListService
    {
        public List<string> GetWords()
        {
            string path = HttpContext.Current.Server.MapPath(@"~/App_Data/words.txt");
            var fileContent = System.IO.File.ReadAllText(path);

            var list = new List<string> { };

            list = fileContent.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            ).ToList();

            return list;
        }
    }
}