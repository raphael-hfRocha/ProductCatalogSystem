using System;
using CatalogoProdutos.Entities;
using CatalogoProdutos.Enums;

namespace CatalogoProdutos 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            int op = 5;

            do
            {
                Menu();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        while (op != 0)
                        {
                        Console.Clear();
                        InserirProduto();
                        op = int.Parse(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Console.WriteLine("\n\n/*****************************************************ROUPAS**********************************************************/");


                                    Console.Write("\n\nDigite o nome do produto: ");
                                    string nome = Console.ReadLine();
                                    Console.Write("\nDigite a marca do produto: ");
                                    string marca = Console.ReadLine();
                                    Console.Write("\nDigite o preço do produto: ");
                                    decimal preco = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nDigite a cor do produto: ");
                                    string cor = Console.ReadLine();
                                    Console.Write("\nDigite o tamanho do produto: ");
                                    string tamanho = Console.ReadLine();
                                    Console.Write("\nDigite a quantidade no estoque: ");
                                    int quantidadeEmEstoque = int.Parse(Console.ReadLine());

                                    Roupa roupa = new Roupa(nome, marca, preco, quantidadeEmEstoque, tamanho, cor);

                                    catalogo.AddProduto(roupa);

                                    op = 5;

                                    break;

                                case 2:
                                    Console.WriteLine("\n\n/*****************************************************ALIMENTO**********************************************************/");

                                    Console.Write("\nDigite o nome do produto: ");
                                    nome = Console.ReadLine();
                                    Console.Write("\nDigite a marca do produto: ");
                                    marca = Console.ReadLine();
                                    Console.Write("\nDigite o preço do produto: ");
                                    preco = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nDigite o tipo de alimento do produto(Comida/Bebida): ");
                                    string tipoAlimentacao = Console.ReadLine();
                                    Console.Write("\nDigite a data de validade do produto(DD/MM/AAAA): ");
                                    DateTime validade = DateTime.Parse(Console.ReadLine());
                                    Console.Write("\nDigite a quantidade no estoque: ");
                                    quantidadeEmEstoque = int.Parse(Console.ReadLine());

                                    Alimento alimento = new Alimento(nome, marca, preco, quantidadeEmEstoque, tipoAlimentacao, validade);

                                    catalogo.AddProduto(alimento);
                                    op = 5;
                                    break;

                                case 3:
                                    Console.WriteLine("\n\n/*****************************************************LIVRO**********************************************************/");

                                    Console.Write("\nDigite o nome do produto: ");
                                    nome = Console.ReadLine();
                                    Console.Write("\nDigite a marca do produto: ");
                                    marca = Console.ReadLine();
                                    Console.Write("\nDigite o preço do produto: ");
                                    preco = decimal.Parse(Console.ReadLine());
                                    Console.Write("\nDigite o título do livro: ");
                                    string titulo = Console.ReadLine();
                                    Console.Write("\nDigite o gênero do livro(Acao/Ficcao/Romance/AutoAjuda): ");
                                    GeneroLivro genero = Enum.Parse<GeneroLivro>(Console.ReadLine());
                                    Console.Write("\nDigite o nome do autor desse livro: ");
                                    string autor = Console.ReadLine();
                                    Console.Write("\nDigite a quantidade de páginas do livro: ");
                                    int qtdePaginas = int.Parse(Console.ReadLine());
                                    Console.Write("\nDigite a quantidade no estoque: ");
                                    quantidadeEmEstoque = int.Parse(Console.ReadLine());

                                    Livro livro = new Livro(nome, marca, preco, quantidadeEmEstoque, titulo, genero, autor, qtdePaginas);

                                    catalogo.AddProduto(livro);
                                    op = 5;
                                    break;

                                case 4:
                                    Menu();
                                    op = int.Parse(Console.ReadLine());
                                    break;

                                default:
                                    Console.WriteLine("A opção digitada é inválida.");
                                    break;

                            }
                        }
                        op = 5;
                        break;

                    case 2:
                        while(op != 0)
                        {
                            Console.Clear();
                            ListarProdutos();
                            op = int.Parse(Console.ReadLine());
                            switch(op)
                            {
                                case 1:

                                    foreach(var alimento in catalogo.)


                                break;
                            }
                        }
                    break;
                        

                    default:
                        Console.WriteLine("A opção digitada é inválida.");
                        break;
                }
            } while (op != 0);
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine($"\n\n[1]-Adicionar produto \n[2]-Listar produtos \n[3]-Atualizar produtos \n[4]-Remover produtos");

            Console.Write("\n\nDigite uma das opções acima: ");
        }

        static void InserirProduto()
        {
            Console.Clear();
            Console.WriteLine($"\n\n[1]-Roupa \n[2]-Alimento \n[3]-Livro \n[4]-Voltar para menu principal");

            Console.Write("\n\nDigite a opção de acordo com os tipos de produtos acima: ");
        }

        static void ListarProdutos()
        {
            Console.Clear();
            Console.WriteLine($"\n\n[1]-Roupa \n[2]-Alimento \n[3]-Livro \n[4]-Voltar para menu principal");

            Console.Write("\n\nDigite a opção de listagem de acordo com os tipos de produtos acima: ");
        }
    }
}