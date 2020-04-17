using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class CommentApiModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field must detected")]
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorApiModel Author { get; set; }

        public int PostId { get; set; }
        public PostApiModel Post { get; set; }

    }
}