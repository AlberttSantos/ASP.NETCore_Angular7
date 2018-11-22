using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Dados.Entities
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
