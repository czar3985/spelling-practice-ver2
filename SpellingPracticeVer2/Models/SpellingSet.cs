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
        [Required]
        [Display(Name = "1.")]
        public string Word1 { get; set; }
        [Required]
        [Display(Name = "2.")]
        public string Word2 { get; set; }
        [Required]
        [Display(Name = "3.")]
        public string Word3 { get; set; }
        [Required]
        [Display(Name = "4.")]
        public string Word4 { get; set; }
        [Required]
        [Display(Name = "5.")]
        public string Word5 { get; set; }
        [Required]
        [Display(Name = "6.")]
        public string Word6 { get; set; }
        [Required]
        [Display(Name = "7.")]
        public string Word7 { get; set; }
        [Required]
        [Display(Name = "8.")]
        public string Word8 { get; set; }
        [Required]
        [Display(Name = "9.")]
        public string Word9 { get; set; }
        [Required]
        [Display(Name = "10.")]
        public string Word10 { get; set; }

        [Display(Name = "1.")]
        public string Answer1 { get; set; }
        [Display(Name = "2.")]
        public string Answer2 { get; set; }
        [Display(Name = "3.")]
        public string Answer3 { get; set; }
        [Display(Name = "4.")]
        public string Answer4 { get; set; }
        [Display(Name = "5.")]
        public string Answer5 { get; set; }
        [Display(Name = "6.")]
        public string Answer6 { get; set; }
        [Display(Name = "7.")]
        public string Answer7 { get; set; }
        [Display(Name = "8.")]
        public string Answer8 { get; set; }
        [Display(Name = "9.")]
        public string Answer9 { get; set; }
        [Display(Name = "10.")]
        public string Answer10 { get; set; }
    }
}