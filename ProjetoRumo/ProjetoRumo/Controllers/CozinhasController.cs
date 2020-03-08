using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoRumo.Data;
using ProjetoRumo.Models;

namespace ProjetoRumo.Controllers
{
    public class CozinhasController : Controller
    {
        private PedidoContext db = new PedidoContext();

        // GET: Cozinhas
        public ActionResult Index()
        {
            return View(db.Cozinha.ToList());
        }

        // GET: Cozinhas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozinha cozinha = db.Cozinha.Find(id);
            if (cozinha == null)
            {
                return HttpNotFound();
            }
            return View(cozinha);
        }

        // GET: Cozinhas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cozinhas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCozinha,Prato,Quantidade")] Cozinha cozinha)
        {
            if (ModelState.IsValid)
            {
                db.Cozinha.Add(cozinha);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cozinha);
        }

        // GET: Cozinhas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozinha cozinha = db.Cozinha.Find(id);
            if (cozinha == null)
            {
                return HttpNotFound();
            }
            return View(cozinha);
        }

        // POST: Cozinhas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCozinha,Prato,Quantidade")] Cozinha cozinha)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cozinha).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cozinha);
        }

        // GET: Cozinhas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cozinha cozinha = db.Cozinha.Find(id);
            if (cozinha == null)
            {
                return HttpNotFound();
            }
            return View(cozinha);
        }

        // POST: Cozinhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cozinha cozinha = db.Cozinha.Find(id);
            db.Cozinha.Remove(cozinha);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
