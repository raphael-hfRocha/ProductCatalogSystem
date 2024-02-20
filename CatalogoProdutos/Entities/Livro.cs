using CatalogoProdutos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Entities
{
    public class Livro : Produto
    {

        public string Titulo { get; set; }
        public GeneroLivro Genero { get; set; }
        public string Autor { get; set; }
        public int QtdePaginas { get; set; }

        public Livro()
        {
        }

        public Livro(string nome, string marca, decimal preco, int quantidadeEmEstoque, string titulo, GeneroLivro genero, string autor, int qtdePaginas) : base(nome, marca, preco, quantidadeEmEstoque)
        {
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            QtdePaginas = qtdePaginas;
        }
    }
}
