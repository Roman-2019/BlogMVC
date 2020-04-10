using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual IEnumerable<PostViewModel> Posts { get; set; }
        public TagViewModel()
        {
            Posts = new List<PostViewModel>();
        }
    }
}