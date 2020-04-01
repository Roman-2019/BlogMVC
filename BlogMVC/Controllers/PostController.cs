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
    public class PostController: IDBController<PostViewModel>
    {
        public readonly IDBService<PostModel> _postViewModelService;
        public PostController()
        {
            _postViewModelService = new PostService();
        }

        public void Add(PostViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PostViewModel GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(PostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}