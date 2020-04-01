using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class PostRepository: IDBRepository<Post>
    {
        public readonly BlogContext _bctx;
        public PostRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Post model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Post model)
        {
            throw new NotImplementedException();
        }
    }
}
