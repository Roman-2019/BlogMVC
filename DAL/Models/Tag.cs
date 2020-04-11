using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        /*public Tag() 
        {
            Posts = new List<Post>();
        }*/
    }
}
