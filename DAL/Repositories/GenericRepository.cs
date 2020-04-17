using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DAL.Interfaces;
using DAL.Models;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public abstract class GenericRepository<T> : IDBRepository<T> where T : class
    {
        private readonly BlogContext _bctx;
        DbSet<T> _dbSet;
        public GenericRepository(BlogContext bctx)
        {
            _bctx = bctx;
            _dbSet = _bctx.Set<T>();
        }

        public void Add(T model)
        {
            _dbSet.Add(model);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var authorDelete = _dbSet.Find(id);
            _dbSet.Remove(authorDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public T GetById(int id)
        {
            //var authorGetById = _bctx.Authors.FirstOrDefault(x => x.Id == id);
            return _dbSet.Find(id);
        }

        public void Update(T model)
        {
            //var updatedAuthor = GetById(model.Id);
            //updatedAuthor.Posts = model.Posts;
            //updatedAuthor.Comments = model.Comments;

            _bctx.Entry(model).State = EntityState.Modified;
            _bctx.SaveChanges();

            //_bctx.Entry(updatedAuthor);
            //_bctx.SaveChanges();
        }
    }
}
