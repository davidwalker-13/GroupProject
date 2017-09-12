using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    public class DmitriController : Controller
    {
        // GET: Dmitrigggg
        public ActionResult Index()
        {
            return View();
        }

        // GET: Dmitri/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dmitri/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dmitri/Create
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

        // GET: Dmitri/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dmitri/Edit/5
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

        // GET: Dmitri/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dmitri/Delete/5
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
