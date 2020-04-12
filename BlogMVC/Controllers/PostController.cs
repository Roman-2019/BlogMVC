using AutoMapper;
using BlogMVC.Models;
using BussinesssLogicLayer.Interfaces;
using BussinesssLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BlogMVC.Controllers
{
    public class PostController : Controller
    {
        /*
        List<PostViewModel> list;
        public PostController()
        {
            list = new List<PostViewModel>
            {
                new PostViewModel{Id=1,Title="ashdjshahkjdksjf",AuthorViewModelId=1,DateTime=DateTime.Parse("01.01.2020") },
                new PostViewModel{Id=2,Title="qwtyetywqewyury",AuthorViewModelId=1,DateTime=DateTime.Parse("01.01.2020") },
                new PostViewModel{Id=3,Title="zxcnbzxvxcz",AuthorViewModelId=2,DateTime=DateTime.Parse("01.01.2020") }
            };
        }*/
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController()
        {

        }
        public PostController(IPostService service, IMapper mapper)
        {
            _mapper = mapper;
            _postService = service;
        }
        // GET: Post
        public ActionResult Index()
        {
            var allPosts = _postService.GetAll();
            var posts = _mapper.Map<IEnumerable<PostViewModel>>(allPosts);
            return View(posts);
            /*
            return View(list);
            */
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            var postModel = _postService.GetById(id);
            var postViewModel = _mapper.Map<PostViewModel>(postModel);
            return View(postViewModel);
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(PostViewModel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var tagModel = _mapper.Map<PostModel>(model);
                _postService.Add(tagModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, PostViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                {
                    return View();
                }
                var tagModel = _mapper.Map<PostModel>(model);
                _postService.Add(tagModel);
                return RedirectToAction("Index");
            }
            catch 
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, PostViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                _postService.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
