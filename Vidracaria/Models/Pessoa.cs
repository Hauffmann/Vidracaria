using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidracaria.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        //[StringLength(10, MinimumLength =6)]
        //[RegularExpression(@"\d{6,10}", ErrorMessage = "Account # must be between 6 and 10 digits.")]
        //[DataType(DataType.Currency)]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[EmailAddress]
        //[Phone]
        //[Display(Name = "Remember this browser?")]
        //Editable
        //Range
        //Url
        //[Required(ErrorMessage = "Digite o nome do produto."), Column(Order = 1)]
        //[MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        //[StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        //[Index(IsUnique = true)]

        //[DisplayFormat(DataFormatString = "{0:n2}",
        //    ApplyFormatInEditMode = true,
        //    NullDisplayText = "Estoque vazio")]
        //[Range(10, 25, ErrorMessage = "A Qtde deverá ser entre 10 e 25.")]
        //[Column(Order = 2)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        // [Required] // Não pode ser obrigatório, porque se for Empresa esse campo ficará vazio.
        // Validar usando javascript; se tipo = PF, campo Nome não pode ser null
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }
        public string Empresa { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public string Email { get; set; }
        public string EmailOutro { get; set; }
        public string Celular { get; set; }
        public string CelularOutro { get; set; }
        public string TelefoneRes { get; set; }
        public string TelefoneCom { get; set; }
        public string Fax { get; set; }
        public string Site { get; set; }
        public string Anotacao { get; set; }
        public int Tipo { get; set; } // 1-PF, 2-PJ, 3-Ambos--Melhor não incluir essa opção, deixar apenas o banco pronto se ele pedir eu coloco
        public string Descricao { get; set; } //funcionario, cliente, fornecedor, loja

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public DateTime? UltimoAcesso { get; set; }

        public DateTime? DataCadastro { get; set; }  //preenchimento automático
        public byte[] ImagemPequena { get; set; }
        public byte[] ImagemMedia { get; set; }
        public byte[] ImagemGrande1 { get; set; }
        public byte[] ImagemGrande2 { get; set; }
        public byte[] ImagemGrande3{ get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public string Extra3 { get; set; }
        public string Extra4 { get; set; }
        public string Extra5 { get; set; }

        //Relationships
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }


        public string NomeInteiro
        {
            get
            {
                return string.Format("{0} {1}", this.Nome, this.Sobrenome);
            }
        }

        
    }
}