using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        [StringLength(12, MinimumLength = 3, ErrorMessage = "Lenth 3-12 characters")]
        public string Text { get; set; }
       
    }
}