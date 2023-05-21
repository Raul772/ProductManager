using RL.Business.Models;

namespace RL.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {

        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}
