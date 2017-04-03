using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }  //VidFos2  Vidro fosco 2mm
        public string Nome { get; set; }
        public string Marca { get; set; }
        public bool? estaAtivo { get; set; }
        public string Tipo { get; set; } //Vidro Plano, Espelho Esférico, ...
        public string Medida { get; set; } // Frontal, Linear, Quantidade
        public string Material { get; set; }
        public string Cor { get; set; } // incolor, azul, ...
        public string Descricao { get; set; }
        public decimal? PrecoVenda { get; set; }
        public string Expessura { get; set; }
        public string Anotacao { get; set; }
        public decimal? QtdadeEstoque { get; set; }
        public byte[] ImagemPequena { get; set; }
        public byte[] ImagemMedia { get; set; }
        public byte[] ImagemGrande { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }

        //Relationships
        // public int DescontoId { get; set; }
        // public virtual Desconto Desconto { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
        public virtual ICollection<Tipo> Tipos { get; set; }
        public virtual ICollection<Pessoa> Pessoas { get; set; }
        public virtual ICollection<PedidoDetalhes> PedidosDetalhes { get; set; }
    }
}