using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesssLogicLayer.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public AuthorModel Author { get; set; }

        public int PostId { get; set; }
        public PostModel Post { get; set; }
    }
}
