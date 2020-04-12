using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlogMVC.Interfaces;
using BlogMVC.Models;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using BussinesssLogicLayer.Services;

namespace BlogMVC.Controllers
{
    public class CategoryController: IDBController<CategoryViewModel>
    {
        public readonly ICategoryService _categoryViewModelService;
        public CategoryController()
        {
            //_categoryViewModelService = new CategoryService();
        }

        public void Add(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CategoryViewModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(CategoryViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}