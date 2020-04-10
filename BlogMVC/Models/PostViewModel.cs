using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public int AuthorViewModelId { get; set; }
        public AuthorViewModel Author { get; set; }

        public virtual IEnumerable<CommentViewModel> Comments { get; set; }
        public virtual IEnumerable<TagViewModel> Tags { get; set; }
        public PostViewModel()
        {
            Comments = new List<CommentViewModel>();
            Tags = new List<TagViewModel>();
        }
    }
}