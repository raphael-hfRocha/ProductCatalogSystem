using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoProdutos.Entities
{
    public class Alimento : Produto
    {

        public string TipoAlimentacao { get; set; }
        public DateTime Validade { get; set; }

        public Alimento()
        {
        }

        public Alimento(string nome, string marca, decimal preco, int quantidadeEmEstoque, string tipoAlimentacao, DateTime validade) : base(nome, marca, preco, quantidadeEmEstoque)
        {
            TipoAlimentacao = tipoAlimentacao;
            Validade = validade;
        }
    }
}
