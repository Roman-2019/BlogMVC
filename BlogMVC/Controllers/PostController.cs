using BlogMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BlogMVC.Controllers
{
    public class PostController : Controller
    {
        List<PostViewModel> list;
        public PostController()
        {
            list = new List<PostViewModel>
            {
                new PostViewModel{Id=1,Title="ashdjshahkjdksjf",Author="Roman",DateTime=DateTime.Parse("01.01.2020") },
                new PostViewModel{Id=2,Title="qwtyetywqewyury",Author="Poni",DateTime=DateTime.Parse("01.01.2020") },
                new PostViewModel{Id=3,Title="zxcnbzxvxcz",Author="Qwerty",DateTime=DateTime.Parse("01.01.2020") }
            };
        }
        // GET: Post
        public ActionResult Index()
        {           
            return View(list);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
