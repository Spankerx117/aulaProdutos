using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet
{
    public class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }
        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string PrecoFinal()
        {
            return $"{Nome} (usado) - {Preco.ToString("c")}, " +
           $"(Fabricado em: {DataFabricacao.ToString("dd/MM/yyyy")}) ";

        }
        

    }


}