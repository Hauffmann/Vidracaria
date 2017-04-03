using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool? estaAtivo { get; set; } // 1-sim, 0-não
        public byte[] ImagemPequena { get; set; }
        public byte[] ImagemMedia { get; set; }
        public byte[] ImagemGrande { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        //Relationships
        public int DescontoId { get; set; }
        public virtual Desconto Desconto { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}