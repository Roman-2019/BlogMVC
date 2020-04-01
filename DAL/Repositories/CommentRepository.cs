using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class CommentRepository: IDBRepository<Comment>
    {
        public readonly BlogContext _bctx;
        public CommentRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Comment model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Comment model)
        {
            throw new NotImplementedException();
        }
    }
}
