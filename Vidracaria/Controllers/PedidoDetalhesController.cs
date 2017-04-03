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
    public class PedidoDetalhesController : Controller
    {
        private VidracariaContext db = new VidracariaContext();

        // GET: PedidoDetalhes
        public ActionResult Index()
        {
            var pedidosDetalhes = db.PedidosDetalhes.Include(p => p.Pedido).Include(p => p.Produto);
            return View(pedidosDetalhes.ToList());
        }

        // GET: PedidoDetalhes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDetalhes pedidoDetalhes = db.PedidosDetalhes.Find(id);
            if (pedidoDetalhes == null)
            {
                return HttpNotFound();
            }
            return View(pedidoDetalhes);
        }

        // GET: PedidoDetalhes/Create
        public ActionResult Create()
        {
            ViewBag.PedidoId = new SelectList(db.Pedidos, "Id", "DetalhePagamento");
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Codigo");
            return View();
        }

        // POST: PedidoDetalhes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Quantidade,PrecoUnitario,PrecoTotal,Medida,Area,Desconto,Acrescimo,ValorDesconto,ValorAcrescimo,eModelado,Anotacao,Extra1,Extra2,Extra3,ProdutoId,PedidoId")] PedidoDetalhes pedidoDetalhes)
        {
            if (ModelState.IsValid)
            {
                db.PedidosDetalhes.Add(pedidoDetalhes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PedidoId = new SelectList(db.Pedidos, "Id", "DetalhePagamento", pedidoDetalhes.PedidoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Codigo", pedidoDetalhes.ProdutoId);
            return View(pedidoDetalhes);
        }

        // GET: PedidoDetalhes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDetalhes pedidoDetalhes = db.PedidosDetalhes.Find(id);
            if (pedidoDetalhes == null)
            {
                return HttpNotFound();
            }
            ViewBag.PedidoId = new SelectList(db.Pedidos, "Id", "DetalhePagamento", pedidoDetalhes.PedidoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Codigo", pedidoDetalhes.ProdutoId);
            return View(pedidoDetalhes);
        }

        // POST: PedidoDetalhes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Quantidade,PrecoUnitario,PrecoTotal,Medida,Area,Desconto,Acrescimo,ValorDesconto,ValorAcrescimo,eModelado,Anotacao,Extra1,Extra2,Extra3,ProdutoId,PedidoId")] PedidoDetalhes pedidoDetalhes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pedidoDetalhes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PedidoId = new SelectList(db.Pedidos, "Id", "DetalhePagamento", pedidoDetalhes.PedidoId);
            ViewBag.ProdutoId = new SelectList(db.Produtos, "Id", "Codigo", pedidoDetalhes.ProdutoId);
            return View(pedidoDetalhes);
        }

        // GET: PedidoDetalhes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PedidoDetalhes pedidoDetalhes = db.PedidosDetalhes.Find(id);
            if (pedidoDetalhes == null)
            {
                return HttpNotFound();
            }
            return View(pedidoDetalhes);
        }

        // POST: PedidoDetalhes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PedidoDetalhes pedidoDetalhes = db.PedidosDetalhes.Find(id);
            db.PedidosDetalhes.Remove(pedidoDetalhes);
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
