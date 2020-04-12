using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        /*public IEnumerable<PostViewModel> Posts { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
       public AuthorViewModel()
        {
            Posts = new List<PostViewModel>();
            Comments = new List<CommentViewModel>();
        }*/
    }
}