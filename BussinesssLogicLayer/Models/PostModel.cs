using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public int AuthorId { get; set; }
        public virtual AuthorModel AuthorModel { get; set; }

        public virtual ICollection<CommentModel> Comments { get; set; }
        public virtual ICollection<TagModel> Tags { get; set; }
      
    }
}
