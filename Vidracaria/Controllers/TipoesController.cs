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
    public class TipoesController : Controller
    {
        private VidracariaContext db = new VidracariaContext();

        // GET: Tipoes
        public ActionResult Index()
        {
            var tipos = db.Tipos.Include(t => t.Desconto);
            return View(tipos.ToList());
        }

        // GET: Tipoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo tipo = db.Tipos.Find(id);
            if (tipo == null)
            {
                return HttpNotFound();
            }
            return View(tipo);
        }

        // GET: Tipoes/Create
        public ActionResult Create()
        {
            ViewBag.DescontoId = new SelectList(db.Descontos, "Id", "Nome");
            return View();
        }

        // POST: Tipoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Codigo,Nome,Descricao,estaAtivo,ImagemPequena,ImagemMedia,ImagemGrande,Extra1,Extra2,Extra3,DescontoId")] Tipo tipo)
        {
            if (ModelState.IsValid)
            {
                db.Tipos.Add(tipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DescontoId = new SelectList(db.Descontos, "Id", "Nome", tipo.DescontoId);
            return View(tipo);
        }

        // GET: Tipoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo tipo = db.Tipos.Find(id);
            if (tipo == null)
            {
                return HttpNotFound();
            }
            ViewBag.DescontoId = new SelectList(db.Descontos, "Id", "Nome", tipo.DescontoId);
            return View(tipo);
        }

        // POST: Tipoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Codigo,Nome,Descricao,estaAtivo,ImagemPequena,ImagemMedia,ImagemGrande,Extra1,Extra2,Extra3,DescontoId")] Tipo tipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DescontoId = new SelectList(db.Descontos, "Id", "Nome", tipo.DescontoId);
            return View(tipo);
        }

        // GET: Tipoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo tipo = db.Tipos.Find(id);
            if (tipo == null)
            {
                return HttpNotFound();
            }
            return View(tipo);
        }

        // POST: Tipoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tipo tipo = db.Tipos.Find(id);
            db.Tipos.Remove(tipo);
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
