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

        public void Add(Category category)
        {
            _bctx.Categories.Add(category);
            _bctx.SaveChanges();
        }

        public void Delete(int id)
        {
            var categoryDelete = GetById(id);
            _bctx.Categories.Remove(categoryDelete);
            _bctx.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _bctx.Categories.AsNoTracking().ToList();
        }

        public Category GetById(int id)
        {
            var categoryGetById = _bctx.Categories.FirstOrDefault(x => x.Id == id);
            return categoryGetById;
        }

        public void Update(Category category)
        {
            var updatedCategory = GetById(category.Id);
            updatedCategory.Title = category.Title;
            updatedCategory.Description = category.Description;
            updatedCategory.Count = category.Count;

            _bctx.Entry(updatedCategory);
            _bctx.SaveChanges();
        }
    }
}
