using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        [Display(Name = "Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* EF Relation */

        [ValidateNever]
        //Posso também usar o [Bind] para selecionar os atributos a serem validados e passados como parâmetro
        public Fornecedor Fornecedor { get; set; }

    }
}
