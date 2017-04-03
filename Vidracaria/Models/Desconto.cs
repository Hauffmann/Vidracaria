using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Desconto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal? ValorAcrescimo { get; set; }

        //Relationships
        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual ICollection<Tipo> Tipos { get; set; }
        // public virtual ICollection<Produto> Produtos { get; set; }
    }
}