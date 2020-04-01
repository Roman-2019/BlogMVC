using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Models;

namespace DAL
{
    public class BlogContext: DbContext
    {
        public BlogContext() : base(@"Data Source=.\SQLSERVER;Initial Catalog=MyBlog;Integrated Security=True")
        {
        }

        DbSet<Post> Posts { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Tag> Tags { get; set; }
    }
}
