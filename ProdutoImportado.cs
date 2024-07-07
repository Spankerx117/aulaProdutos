using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet
{
    public class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

    public ProdutoImportado()
    {

    }
    public ProdutoImportado(string nome, double preco, double taxaImportacao) : base(nome, preco)
    {
         TaxaImportacao = taxaImportacao;
    }
    public double PrecoTotal()
        {
            return Preco + TaxaImportacao;
        }

        public override string PrecoFinal()
        {
            return $"{Nome} - {PrecoTotal().ToString("c")}"+
            $"(Custos de importação:  {TaxaImportacao.ToString("c")})";
                   
        }










    }

}