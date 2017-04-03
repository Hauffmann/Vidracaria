using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Pedido
    {
        public int Id { get; set; }  // É para ID ficar exposta, pedido número tal
        public DateTime? DataPedido { get; set; } // Automático
        public DateTime? DataEntrega { get; set; }
        public bool? Status { get; set; } // 1=concluído, 0=em aberto
        public bool? ePedido { get; set; }  // Pedido ou Orçamento
        public string DetalhePagamento { get; set; } // MasterCard, Visa, Elo, blablabla
        public decimal? Desconto { get; set; } // se valor, campo ValorDesconto calcula automatico com base no valor
        public decimal? Acrescimo { get; set; }
        public decimal? ValorDesconto { get; set; } // se valor, campo Desconto (porcentagem) calcula automatico com base no valor
        public decimal? ValorAcrescimo { get; set; } // se valor, campo Acrescimo (porcentagem) calcula automatico com base no valor
        public decimal? ValorTotal { get; set; }
        public string Anotacao { get; set; }

        //Relationships
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<PedidoDetalhes> PedidosDetalhes { get; set; }
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}