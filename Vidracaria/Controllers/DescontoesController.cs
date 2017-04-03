using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidracaria.Models;

namespace Vidracaria.Controllers
{
    public class DescontoesController : Controller
    {
        private VidracariaContext db = new VidracariaContext();

        // GET: Descontoes
        public ActionResult Index()
        {
            return View(db.Descontos.ToList());
        }

        // GET: Descontoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desconto desconto = db.Descontos.Find(id);
            if (desconto == null)
            {
                return HttpNotFound();
            }
            return View(desconto);
        }

        // GET: Descontoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Descontoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,ValorDesconto,ValorAcrescimo")] Desconto desconto)
        {
            if (ModelState.IsValid)
            {
                db.Descontos.Add(desconto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(desconto);
        }

        // GET: Descontoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desconto desconto = db.Descontos.Find(id);
            if (desconto == null)
            {
                return HttpNotFound();
            }
            return View(desconto);
        }

        // POST: Descontoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,ValorDesconto,ValorAcrescimo")] Desconto desconto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(desconto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(desconto);
        }

        // GET: Descontoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Desconto desconto = db.Descontos.Find(id);
            if (desconto == null)
            {
                return HttpNotFound();
            }
            return View(desconto);
        }

        // POST: Descontoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Desconto desconto = db.Descontos.Find(id);
            db.Descontos.Remove(desconto);
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
