using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpellingPracticeVer2.Models
{
    public class SpellingSet
    {
        public List<string> words { get; set; }
    }

    public class SpellingViewModel
    {
        public bool UsePrevious { get; set; }

        [Display(Name = "1.")]
        public string Word1 { get; set; }

        [Display(Name = "2.")]
        public string Word2 { get; set; }

        [Display(Name = "3.")]
        public string Word3 { get; set; }

        [Display(Name = "4.")]
        public string Word4 { get; set; }

        [Display(Name = "5.")]
        public string Word5 { get; set; }

        [Display(Name = "6.")]
        public string Word6 { get; set; }

        [Display(Name = "7.")]
        public string Word7 { get; set; }

        [Display(Name = "8.")]
        public string Word8 { get; set; }

        [Display(Name = "9.")]
        public string Word9 { get; set; }

        [Display(Name = "10.")]
        public string Word10 { get; set; }
    }
}