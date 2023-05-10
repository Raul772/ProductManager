using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {

        


        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 11)]
        public string Documento { get; set;}

        [DisplayName("Pessoa Física ou Jurídica")]
        public TipoFornecedor TipoFornecedor { get; set;}

        public Endereco Endereco { get; set;}

        [DisplayName("Ativo")]
        public bool Ativo { get; set;}

        /* EF Relation */
        [ValidateNever]
        public IEnumerable<Produto> Produtos { get; set; }


    }
}
