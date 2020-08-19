﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class InvoicesController : Controller
    {
        private Manager m = new Manager();

        // GET: Invoices
        public ActionResult Index()
        {
            var i = m.InvoiceGetAll();

            return View(i);
        }

        public ActionResult oneInvoiceIndex(int? id)
        {
            var oi = m.InvoiceGetById(id);

            return View("index", oi);
        }

        // GET: Invoices/Details/5
        public ActionResult Details(int? id)
        {
            // Attempt to get the matching object
            var obj = m.InvoiceGetByIdWithDetail(id.GetValueOrDefault()); //The GetValueOrDefault function works if the value matches the type then returns value, otherwise returns 0.
            if (obj == null)
                return HttpNotFound();
            else
                return View(obj);
        }

        // GET: Invoices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Invoices/Create
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

        // GET: Invoices/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Invoices/Edit/5
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

        // GET: Invoices/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Invoices/Delete/5
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