using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BlogMVC.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="This field must detected")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        [StringLength(12,MinimumLength = 3, ErrorMessage ="Lenth 3-12 characters")]
        public string Login { get; set; }

        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 5, ErrorMessage = "Lenth 5-16 characters")]
        public string Password { get; set; }
        public string Status { get; set; }
        //public IEnumerable<PostViewModel> Posts { get; set; }
        //public IEnumerable<CommentViewModel> Comments { get; set; }
      
    }
}