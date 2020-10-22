using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancJF.Models
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }

        public double Preco { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public ItemPedido()
        {
        }

        public ItemPedido(int id, double quantidade, double preco)
        {
            Id = id;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void AddProduto(Produto prod)
        {
            Produtos.Add(prod);
        }

        public void RemoveProdutos(Produto prod)
        {
            Produtos.Remove(prod);
        }
    }
}
