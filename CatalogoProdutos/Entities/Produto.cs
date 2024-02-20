using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, string marca, decimal preco, int quantidadeEmEstoque)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
    }
}