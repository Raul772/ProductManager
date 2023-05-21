using RL.Business.Models;

namespace RL.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {

        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);

        Task<IEnumerable<Produto>> ObterProdutosFornecedores();

        Task<Produto> ObterProdutoFornecedor(Guid fornecedorId);

    }
}
