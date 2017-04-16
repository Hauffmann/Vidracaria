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
    public class FormaPagamentoesController : Controller
    {
        private VidracariaContext db = new VidracariaContext();

        // GET: FormaPagamentoes
        public ActionResult Index()
        {
            return View(db.FormaPagamentos.ToList());
        }

        // GET: FormaPagamentoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaPagamento formaPagamento = db.FormaPagamentos.Find(id);
            if (formaPagamento == null)
            {
                return HttpNotFound();
            }
            return View(formaPagamento);
        }

        // GET: FormaPagamentoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormaPagamentoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Descricao,Desconto,Acrescimo,Extra1,Extra2,Extra3")] FormaPagamento formaPagamento)
        {
            if (ModelState.IsValid)
            {
                db.FormaPagamentos.Add(formaPagamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(formaPagamento);
        }

        // GET: FormaPagamentoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaPagamento formaPagamento = db.FormaPagamentos.Find(id);
            if (formaPagamento == null)
            {
                return HttpNotFound();
            }
            return View(formaPagamento);
        }

        // POST: FormaPagamentoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Descricao,Desconto,Acrescimo,Extra1,Extra2,Extra3")] FormaPagamento formaPagamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(formaPagamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(formaPagamento);
        }

        // GET: FormaPagamentoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FormaPagamento formaPagamento = db.FormaPagamentos.Find(id);
            if (formaPagamento == null)
            {
                return HttpNotFound();
            }
            return View(formaPagamento);
        }

        // POST: FormaPagamentoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FormaPagamento formaPagamento = db.FormaPagamentos.Find(id);
            db.FormaPagamentos.Remove(formaPagamento);
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
