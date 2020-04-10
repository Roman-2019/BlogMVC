using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Repositories
{
    public class AuthorRepository: IDBRepository<Author>
    {
        private readonly BlogContext _bctx;
        public AuthorRepository()
        {
            _bctx = new BlogContext();
        }

        public void Add(Author author)
        {
            _bctx.Authors.Add(author);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var authorDelete = GetById(id);
            _bctx.Authors.Remove(authorDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<Author> GetAll()
        {
            return _bctx.Authors.AsNoTracking().ToList();
        }

        public Author GetById(int id)
        {
            var authorGetById = _bctx.Authors.FirstOrDefault(x => x.Id == id);
            return authorGetById;
        }

        public void Update(Author author)
        {
            var updatedAuthor = GetById(author.Id);
            updatedAuthor.Posts = author.Posts;
            updatedAuthor.Comments = author.Comments;

            _bctx.Entry(updatedAuthor);
            _bctx.SaveChanges();
        }
    }
}
