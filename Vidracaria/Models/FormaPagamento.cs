using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Desconto { get; set; }
        public decimal Acrescimo { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        //Relationships
        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}