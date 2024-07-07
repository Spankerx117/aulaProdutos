using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet
{
    public class Produto
    {


        public string? Nome { get; set; }
        public double Preco { get; set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string PrecoFinal()
        {
            return $"{Nome} - {Preco.ToString("c")}";
        }

    }
}
