using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancJF.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double VlrEntrega { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(int id, DateTime data, double vlrEntrega)
        {
            Id = id;
            Data = data;
            VlrEntrega = vlrEntrega;
        }

        public void AddItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoveItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public double GetTotalPedido()
        {
            return Itens.Sum(item => item.Quantidade * item.Preco);
        }
    }
}
