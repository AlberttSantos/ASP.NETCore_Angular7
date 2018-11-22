using ProjetoWebEntityFramework.Dados;
using ProjetoWebEntityFramework.Dados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Model
{
    public class ProductRepository : IProductRepository
    {
        //readonly -> somente de leitura
        private readonly WebEntityFrameworkContext _webEntityFrameworkContext;

        public ProductRepository(WebEntityFrameworkContext webEntityFrameworkContext)
        {
            _webEntityFrameworkContext = webEntityFrameworkContext;
        }

        public List<Produto> ListarProdutos()
        {
            return _webEntityFrameworkContext.Produto.ToList();
        }
    }
}
