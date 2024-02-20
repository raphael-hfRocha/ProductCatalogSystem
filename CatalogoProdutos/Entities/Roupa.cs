using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Entities
{
    public class Roupa : Produto
    {

        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public Roupa()
        {
        }

        public Roupa(string nome, string marca, decimal preco, int quantidadeEmEstoque, string tamanho, string cor) : base(nome, marca, preco, quantidadeEmEstoque)
        {
            Tamanho = tamanho;
            Cor = cor;
        }
    }
}
