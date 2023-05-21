using Microsoft.EntityFrameworkCore;
using RL.Business.Interfaces;
using RL.Business.Models;

namespace RL.Data.Repository
{
    internal class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public async Task<Produto> ObterProdutoFornecedor(Guid fornecedorId)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(p => p.Id == fornecedorId);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
