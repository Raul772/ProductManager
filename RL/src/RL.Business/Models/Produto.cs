using System.ComponentModel.DataAnnotations;

namespace RL.Business.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /* EF Relation */

        //Posso também usar o [Bind] para selecionar os atributos a serem validados e passados como parâmetro
        public Fornecedor Fornecedor { get; set; }

    }
}
