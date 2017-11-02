using ASPNETKata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETKata.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var list = new List<Person>();

            list.Add(new Person { Age = 14, IsMinor = true, Name = "Harry" });
            list.Add(new Person { Age = 20, IsMinor = false, Name = "Johnny" });
            list.Add(new Person { Age = 26, IsMinor = false, Name = "Persephone" });
            list.Add(new Person { Age = 86, IsMinor = false, Name = "Bobby" });
            list.Add(new Person { Age = 03, IsMinor = true, Name = "Sissy" });
            list.Add(new Person { Age = 10, IsMinor = true, Name = "Lincoln" });
            list.Add(new Person { Age = 14, IsMinor = true, Name = "Hamilton" });
            list.Add(new Person { Age = 6, IsMinor = true, Name = "Lucy" });
            list.Add(new Person { Age = 39, IsMinor = false, Name = "Sonu" });

            return View(list);
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
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

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
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

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
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
