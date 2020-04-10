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

        public void Add(Tag tag)
        {
            _bctx.Tags.Add(tag);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var tagDelete = GetById(id);
            _bctx.Tags.Remove(tagDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<Tag> GetAll()
        {
            return _bctx.Tags.AsNoTracking().ToList();
        }

        public Tag GetById(int id)
        {
            var tagGetById = _bctx.Tags.FirstOrDefault(x => x.Id == id);
            return tagGetById;
        }

        public void Update(Tag tag)
        {
            var updatedTag = GetById(tag.Id);
            updatedTag.Posts = tag.Posts;  

            _bctx.Entry(updatedTag);
            _bctx.SaveChanges();
        }
    }
}
