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
    public class CommentController: IDBController<CommentViewModel>
    {
        public readonly IDBService<CommentModel> _commentViewModelService;
        public CommentController()
        {
            //_commentViewModelService = new CommentService();
        }

        public void Add(CommentViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CommentViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CommentViewModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(CommentViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}