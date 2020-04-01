using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class TagRepository: IDBRepository<Tag>
    {
        public readonly BlogContext _bctx;
        public TagRepository() 
        {
            _bctx = new BlogContext();
        }

        public void Add(Tag model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tag GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Tag model)
        {
            throw new NotImplementedException();
        }
    }
}
