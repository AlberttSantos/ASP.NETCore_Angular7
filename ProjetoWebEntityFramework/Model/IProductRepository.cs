using System.Collections.Generic;
using ProjetoWebEntityFramework.Dados.Entities;

namespace ProjetoWebEntityFramework.Model
{
    public interface IProductRepository
    {
        List<Produto> ListarProdutos();
        void Salvar(Produto produto);
    }
}