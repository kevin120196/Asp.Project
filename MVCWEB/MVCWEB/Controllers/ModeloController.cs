using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWEB.Models;
using MVCWEB.Models.ModeloModel;
using MVCWEB.Models.ModeloRequest;

namespace MVCWEB.Controllers
{
    public class ModeloController : Controller
    {
        // GET: Modelo
        public ActionResult Index()
        {
            List<modeloModel> lst = null;
            using (TiendaOnlineEntities1 db=new TiendaOnlineEntities1())
            {
                lst = (from d in db.Modelo
                       select new modeloModel
                       {
                           idModelo = d.id,
                           NombreModelo = d.NombreModelo
                       }).ToList();
            }

            return View(lst);
        }

        // GET: Modelo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Modelo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modelo/Create
        [HttpPost]
        public ActionResult Create(modeloRequest Request)
        {
            if (!ModelState.IsValid)
            {
                return View(Request);
            }
            using (var db = new TiendaOnlineEntities1())
            {
                Modelo Modelo = new Modelo();
                Modelo.NombreModelo = Request.NombreModelo;
                db.Modelo.Add(Modelo);
                db.SaveChanges();

            }
            return Redirect(Url.Content("~/Modelo/"));
        }

        // GET: Modelo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Modelo/Edit/5
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

        // GET: Modelo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Modelo/Delete/5
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
