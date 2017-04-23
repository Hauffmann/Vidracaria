using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Endereco
    {
        public int Id { get; set; }

        [Required]
        //[Display(Name = "Nome")]
        public string Logradouro { get; set; }

        [Required]
        public int? Numero { get; set; }

        [Required]
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Referencia { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }

        //Relationships
        public virtual ICollection<Pessoa> Pessoas { get; set; }

        public string End
        {
            get
            {
                return string.Format("{0}, {1}", this.Logradouro, this.Numero);
            }
        }
    }
}