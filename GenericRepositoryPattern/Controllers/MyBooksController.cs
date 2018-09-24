using GenericRepositoryPattern.Models;
using GenericRepositoryPattern.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepositoryPattern.Controllers
{
    public class MyBooksController : Controller
    {
        // GET: MyBooks

        private _IAllRepository<Book> interfaceobj;
        public MyBooksController()
        {
            this.interfaceobj = new AllRepository<Book>();
        }
        public ActionResult Index()
        {
            return View(from m in interfaceobj.GetModel() select m);
        }

        // GET: MyBooks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MyBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyBooks/Create
        [HttpPost]
        public ActionResult Create(Book collection)
        {
            try
            {
                // TODO: Add insert logic here
                interfaceobj.InsertModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyBooks/Edit/5
        public ActionResult Edit(int id)
        {
            Book b = interfaceobj.GetModelByID(id);
            return View(b);
        }

        // POST: MyBooks/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Book collection)
        {
            try
            {
                // TODO: Add update logic here
                interfaceobj.UpdateModel(collection);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MyBooks/Delete/5
        public ActionResult Delete(int id)
        {

            Book b = interfaceobj.GetModelByID(id);
            return View(b);
        }

        // POST: MyBooks/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Book collection)
        {
            try
            {
                // TODO: Add delete logic here
                interfaceobj.DeleteModel(id);
                interfaceobj.Save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
