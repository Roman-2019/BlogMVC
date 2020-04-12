using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorViewModel Author { get; set; }

        public int PostId { get; set; }
        public PostViewModel Post { get; set; }
    }
}