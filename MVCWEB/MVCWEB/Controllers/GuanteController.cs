﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWEB.Controllers
{
    public class GuanteController : Controller
    {
        // GET: Guante
        public ActionResult Index()
        {
            return View();
        }

        // GET: Guante/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Guante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guante/Create
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

        // GET: Guante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Guante/Edit/5
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

        // GET: Guante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Guante/Delete/5
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
