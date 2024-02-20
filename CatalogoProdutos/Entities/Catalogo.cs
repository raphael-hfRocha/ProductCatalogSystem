using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Entities
{
    public class Catalogo
    {

        public List<Produto> produtos = new List<Produto>();

        public Catalogo()
        {
        }

        private bool ValidarProduto(Produto produto)
        {
            if (produto.Preco <= 0 || string.IsNullOrWhiteSpace(produto.Nome))
            {
                return false;
            }

            if(produto is Roupa)
            {
                Roupa roupa = (Roupa)produto;

                return !string.IsNullOrWhiteSpace(roupa.Tamanho) && !string.IsNullOrWhiteSpace(roupa.Cor);
            }

            if(produto is Alimento)
            {
                Alimento alimento = (Alimento)produto;

                return alimento.Validade > DateTime.Now;
            }

            if(produto is Livro)
            {
                Livro livro = (Livro)produto;

                return !string.IsNullOrWhiteSpace(livro.Titulo) && !string.IsNullOrWhiteSpace(livro.Autor) && livro.QtdePaginas > 0;
            }

            return true;
        }

        public void AddProduto(Produto produto)
        {
            if(ValidarProduto(produto))
            {
                produtos.Add(produto);
                Console.WriteLine("Produto Adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro ao adicionar produto. Verifique os dados inseridos.");
            }
        }

        public void AtualizarProduto(string nome, Produto novoProduto)
        {
            Produto produtoExistente = produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if(produtoExistente != null)
            {
                if(ValidarProduto(novoProduto))
                {
                    int index = produtos.IndexOf(produtoExistente);
                    produtos[index] = novoProduto;
                    Console.WriteLine("Produto atualizado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Erro ao atualizar produto. Verifique os dados inseridos.");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void RemoverProduto(string nome)
        {
            Produto produtoExistente = produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if(produtoExistente != null)
            {
                produtos.Remove(produtoExistente);
                Console.WriteLine("Produto removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }


        public void ListarProdutosEmDesconto()
        {
            Console.WriteLine("Produtos em Desconto:");

            foreach(var produto in produtos)
            {
                decimal desconto = CalcularDesconto(produto);
                if(desconto > 0)
                {
                    Console.WriteLine($"{produto.Nome} - Desconto: {desconto}%");
                }
            }
        }

        private decimal CalcularDesconto(Produto produto)
        {
            if(produto is Roupa)
            {
                return produto.Preco * 0.5m;
            }
            if(produto is Livro)
            {
                return produto.Preco * 0.3m;
            }

            return 0;
        }
    }
}
