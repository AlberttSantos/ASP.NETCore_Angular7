using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWebEntityFramework.Dados.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
