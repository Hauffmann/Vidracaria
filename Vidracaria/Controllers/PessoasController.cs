using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidracaria.Models;

namespace Vidracaria.Controllers
{
    public class PessoasController : Controller
    {
        private VidracariaContext db = new VidracariaContext();

        // GET: Pessoas
        public ActionResult Index()
        {
            return View(db.Pessoas.ToList());
        }

        // GET: Pessoas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // GET: Pessoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Sobrenome,Empresa,DataNascimento,Cpf,Rg,Cnpj,InscricaoEstadual,Email,EmailOutro,Celular,CelularOutro,TelefoneRes,TelefoneCom,Fax,Site,Anotacao,Tipo,Descricao,Usuario,Senha,UltimoAcesso,DataCadastro,ImagemPequena,ImagemMedia,ImagemGrande1,ImagemGrande2,ImagemGrande3,Extra1,Extra2,Extra3,Extra4,Extra5")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Sobrenome,Empresa,DataNascimento,Cpf,Rg,Cnpj,InscricaoEstadual,Email,EmailOutro,Celular,CelularOutro,TelefoneRes,TelefoneCom,Fax,Site,Anotacao,Tipo,Descricao,Usuario,Senha,UltimoAcesso,DataCadastro,ImagemPequena,ImagemMedia,ImagemGrande1,ImagemGrande2,ImagemGrande3,Extra1,Extra2,Extra3,Extra4,Extra5")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pessoa pessoa = db.Pessoas.Find(id);
            if (pessoa == null)
            {
                return HttpNotFound();
            }
            return View(pessoa);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pessoa pessoa = db.Pessoas.Find(id);
            db.Pessoas.Remove(pessoa);
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

        public JsonResult Pessoas()
        {
            //var query = db.Pessoas
            //    .Select(p => new { p.Nome, p.Sobrenome, p.Empresa, p.Cpf, p.Cnpj, p.Descricao, Valor = p.Pedidos.Select(a => a.ValorTotal) })
            //    .Where(p => p.Descricao.Equals("Cliente") && p.Nome.Length > 0)
            //    .ToList();
            //return Json(query, JsonRequestBehavior.AllowGet);

            var query2 = db.Pessoas
                .Select(p => p)
                .Where(p => p.Descricao.Equals("Cliente") && p.Nome.Length > 0)
                .ToList();
            return Json(query2, JsonRequestBehavior.AllowGet);
        }


        /*
        public JsonResult Test([DataSourceRequest] DataSourceRequest request)
        {
            var data = DataSource;
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        */


        [HttpPost]
        public ActionResult KendoCreate(Pessoa pessoa)
        {   
            if (pessoa != null)
            {
                db.Pessoas.Add(pessoa);
                db.SaveChanges();
                return Json(pessoa);
            }
            else
            {
                return Json("An Error Has Occurred");
            }
        }


        [HttpPost]
        public ActionResult KendoUpdate(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                db.Entry(pessoa).State = EntityState.Modified;
                db.SaveChanges();
                return Json(pessoa);
            }
            else
            {
                return Json("An Error Has Occurred");
            }
        }


        [HttpPost]
        public ActionResult KendoDelete(Pessoa pessoa)
        {
            if (pessoa != null)
            {
                Pessoa p = db.Pessoas.Find(pessoa.Id);
                db.Pessoas.Remove(p);
                db.SaveChanges();
                return Json(pessoa);
            }
            else
            {
                return Json("An Error Has Occurred");
            }
        }
    }
}