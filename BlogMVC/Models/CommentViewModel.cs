using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

    }
}