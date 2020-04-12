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
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController()
        {

        }
        public CommentController(ICommentService service, IMapper mapper)
        {
            _mapper = mapper;
            _commentService = service;
        }
        // GET: Comment
        public ActionResult Index()
        {
            var allComments = _commentService.GetAll();
            var comments = _mapper.Map<IEnumerable<CommentViewModel>>(allComments);
            return View(comments);
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            var commentModel = _commentService.GetById(id);
            var commentViewModel = _mapper.Map<AuthorViewModel>(commentModel);
            return View(commentViewModel);
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create(CommentViewModel model)
        {
            //try
            //{
            // TODO: Add insert logic here
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (ModelState.IsValid) { 
                var commentModel = _mapper.Map<CommentModel>(model);
                _commentService.Add(commentModel);
                return RedirectToAction("Index");
            }
            //catch
            //{
                return View();
            //}
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CommentViewModel model)
        {
            //try
            //{
            // TODO: Add update logic here
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (ModelState.IsValid) { 
                var commentModel = _mapper.Map<CommentModel>(model);
                _commentService.Update(commentModel);
                return RedirectToAction("Index");
            }
            //catch
            //{
                return View();
            //}
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Comment/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CommentViewModel model)
        {
            try
            {
                // TODO: Add delete logic here
                _commentService.Remove(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
