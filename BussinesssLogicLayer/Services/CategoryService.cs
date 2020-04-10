using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;

namespace BussinesssLogicLayer.Services
{
    public class CategoryService:IDBService<CategoryModel>
    {
        private readonly IDBRepository<Category> _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new CategoryRepository();
        }

        public void Add(CategoryModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
