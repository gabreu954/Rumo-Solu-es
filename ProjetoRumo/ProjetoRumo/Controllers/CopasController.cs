﻿using System;
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
    public class CopasController : Controller
    {
        private PedidoContext db = new PedidoContext();

        // GET: Copas
        public ActionResult Index()
        {
            return View(db.Copa.ToList());
        }

        // GET: Copas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copa copa = db.Copa.Find(id);
            if (copa == null)
            {
                return HttpNotFound();
            }
            return View(copa);
        }

        // GET: Copas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Copas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCopa,Bebida,Quantidade")] Copa copa)
        {
            if (ModelState.IsValid)
            {
                db.Copa.Add(copa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(copa);
        }

        // GET: Copas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copa copa = db.Copa.Find(id);
            if (copa == null)
            {
                return HttpNotFound();
            }
            return View(copa);
        }

        // POST: Copas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCopa,Bebida,Quantidade")] Copa copa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(copa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(copa);
        }

        // GET: Copas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Copa copa = db.Copa.Find(id);
            if (copa == null)
            {
                return HttpNotFound();
            }
            return View(copa);
        }

        // POST: Copas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Copa copa = db.Copa.Find(id);
            db.Copa.Remove(copa);
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
