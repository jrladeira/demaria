using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeMaria.Modelo
{
    class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime PedidoData { get; set; }
        public int QuantidadeTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();
    }
}
