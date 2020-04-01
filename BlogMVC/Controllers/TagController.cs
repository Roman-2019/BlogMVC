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
    public class TagController: IDBController<TagViewModel>
    {
        public readonly IDBService<TagModel> _tagViewModelService;
        public TagController() 
        {
            _tagViewModelService = new TagService();
        }

        public void Add(TagViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TagViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public TagViewModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(TagViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}