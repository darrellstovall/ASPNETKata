using ASPNETKata.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace ASPNETKata.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var connectionString = "Server=localhost;Database=Adventureworks;Uid=root;Pwd=5Fingers";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var list = conn.Query<Product>("Select * from Product ORDER By ProductID DESC");
                return View(list);
            }
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var name = collection ["Name"];

            var connectionString = "Server=localhost;Database=Adventureworks;Uid=root;Pwd=5Fingers";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    conn.Execute("INSERT INTO product (Name) VALUES (@Name)", new { Name = name });
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var name = collection["Name"];

            var connectionString = "Server=localhost;Database=Adventureworks;Uid=root;Pwd=5Fingers";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    conn.Execute("UPDATE product SET Name = @Name WHERE ProductId = @Id", new { Name = name, Id = id });
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
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
