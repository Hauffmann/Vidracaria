using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int NumeroParcela { get; set; }
        public decimal ValorParcela { get; set; }
        public string Anotacao { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        //Relationships
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual ICollection<FormaPagamento> FormaPagamentos { get; set; }
    }
}