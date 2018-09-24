using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GenericRepositoryPattern.Models;
using GenericRepositoryPattern.Models.DAL;

namespace GenericRepositoryPattern.Controllers
{
    public class LoginsController : Controller
    {
        // GET: Logins
        private _IAllRepository<Login> interfaceobj;
        public LoginsController()
        {
            this.interfaceobj = new AllRepository<Login>();
        }
        public ActionResult Index()
        {

            return View(from m in interfaceobj.GetModel() select m);
        }

        // GET: Logins/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Logins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Logins/Create
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

        // GET: Logins/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Logins/Edit/5
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

        // GET: Logins/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Logins/Delete/5
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
