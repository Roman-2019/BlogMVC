using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class CategoryRepository: IDBRepository<Category>
    {
        public readonly BlogContext _bctx;
        public CategoryRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Category model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
