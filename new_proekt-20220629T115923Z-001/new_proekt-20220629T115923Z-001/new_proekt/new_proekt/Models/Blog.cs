using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace new_proekt.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string BlogTitle { get; set; }
        [Required]
        [Display(Name = "Content")]
        public string BLogContent { get; set; }
        [Display(Name = "Tag")]
        public List<string> BlogTags { get; set; }

        [Required]
        [Display(Name = "Date and Time")]
        // Time based properties  
        public DateTime BLogTime { get; set; }

    }
}