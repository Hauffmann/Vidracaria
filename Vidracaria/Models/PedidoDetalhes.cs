using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class PedidoDetalhes
    {
        public int Id { get; set; }
        public int? Quantidade { get; set; }
        public decimal? PrecoUnitario { get; set; }
        public decimal? PrecoTotal { get; set; }
        public string Medida { get; set; } // altura, largura => pode ser 2 medidas, 3 (triangulo), 4 (lados diferentes), ...
        public decimal? Area { get; set; } // area caculada, pode ser m2 ou linear
        public decimal? Desconto { get; set; }  // porcentagem
        public decimal? Acrescimo { get; set; } // porcentagem
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorAcrescimo { get; set; }
        public bool? eModelado { get; set; } // vidro é modelado?
        public string Anotacao { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        //Relationships
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }

        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}