using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidracaria.Models;

namespace Vidracaria.Controllers
{
    public class HomeController : Controller
    {

        private VidracariaContext db = new VidracariaContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        public JsonResult Pessoas()
        {

            //Codigo original
            //var query = (from p in db.Pessoas
            //                 //where p.Age < 30
            //                 //orderby p.Name
            //             select p).ToList();

            //return Json(query, JsonRequestBehavior.AllowGet);



            // Messing aroung

            //var query = (
            //            from p in db.Pessoas
            //            from a in p.Pedidos
            //            from b in a.PedidosDetalhes
            //            where p.Descricao == "Cliente" && p.Nome.Length > 0
            //            orderby p.Nome
            //            select new { p.Nome, p.Sobrenome, p.Cpf, p.Pedidos, b.PrecoTotal }
            //             )
            //             .ToList();

            //var query = (
            //            from p in db.Pessoas
            //            //from a in p.Pedidos
            //            //from b in a.PedidosDetalhes
            //            where p.Descricao == "Cliente" && p.Nome.Length > 0
            //            orderby p.Nome
            //            select new { p.Nome, p.Sobrenome, p.Cpf, p.Pedidos }
            //             )
            //             .ToList();


            var query = db.Pessoas
                .Select(p => new { p.Nome, p.Sobrenome, p.Cpf, p.Descricao, Valor = p.Pedidos.Select(a => a.ValorTotal)})
                .Where(p => p.Descricao.Equals("Cliente") && p.Nome.Length > 0)
                .OrderBy(p => p.Nome)
                .ToList();
            






            //var query = (from p in context.Pessoas
            //             from a in p.Pedidos
            //            // where a.Status.Equals(1)
            //             select new
            //             {
            //                 p.Nome,
            //                 p.Sobrenome,
            //                 p.Cpf,
            //                 a.DataPedido,
            //                 a.Status
            //             }).ToList();

            //var query = db.Pessoas
            //.Where(p => p.Pedidos.Where(a => a.Status.Equals(1))).ToList();
            //    .SelectMany(p => p.Pedidos).ToList();
            //.Select(p => p.Pedidos).ToList();
            //.Select(p => p).Select(p => p.Pedidos).ToList();
            //.Select(p => p).SelectMany(a => a.Pedidos).ToList();
            //.Select(p => new { p.Nome, p.Sobrenome, p.Cpf, p.Pedidos }).ToList(); // retornou certo
            //.Select(p => p.Nome.Contains("D")).ToList();
            //.Select(p => new { p.Nome, p.Sobrenome, p.Cpf, p.Pedidos }).Where(p => p.Nome.StartsWith("d")).ToList();
            //.Select(p => new { p.Nome, p.Sobrenome, p.Cpf, p.Pedidos }).Where(p => p.Nome.Length > 0).OrderBy(p => p.Nome).ToList();
            //var query = (


            //    from p in context.Pessoas
            //        //where p.Age < 30
            //        //orderby p.Name
            //    select p).ToList();




            return Json(query, JsonRequestBehavior.AllowGet);

        }



    }
}