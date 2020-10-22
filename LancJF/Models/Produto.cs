using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LancJF.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Unidade { get; set; }
        public double Quantidade { get; set; }

        public Categoria Categoria { get; set; }

        public HashSet<Produto> Ingredientes { get; set; } = new HashSet<Produto>();

        public HashSet<Pedido> Pedidos { get; set; } = new HashSet<Pedido>();

        public int CategoriaId { get; set; }

        public Produto()
        {
        }

        public Produto(int id, string nome, double preco, string unidade, double quantidade, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Unidade = unidade;
            Quantidade = quantidade;
            Categoria = categoria;
        }

        public void AddIngrediente(Produto ing)
        {
            Ingredientes.Add(ing);
        }

        public void RemoveIngrediente(Produto ing)
        {
            Ingredientes.Remove(ing);
        }

        public void AddPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }

        public void RemovePedido(Pedido pedido)
        {
            Pedidos.Remove(pedido);
        }
    }
}
