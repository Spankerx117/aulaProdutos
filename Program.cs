using System;
using System.Collections.Generic;
using System.Globalization;
using dotnet;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Produto> list = new List<Produto>();

        Console.Write("Digite a quantidade de produtos: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Número inválido. Digite novamente: ");
        }

        int i = 1;
        while (i <= n)
        {
            Console.WriteLine($"Dados do Produto #{i}:");
            Console.Write("Produto comum, usado ou importado (c/u/i)? ");
            char ch;
            while (!char.TryParse(Console.ReadLine().ToLower(), out ch) || (ch != 'c' && ch != 'u' && ch != 'i'))
            {
                Console.WriteLine("Dígito inválido. Digite novamente (c/u/i): ");
            }

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco;
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out preco) || preco <= 0)
            {
                Console.WriteLine("Preço inválido. Digite novamente: ");
            }

            if (ch == 'c')
            {
                list.Add(new Produto(nome, preco));
            }
            else if (ch == 'u')
            {
                Console.Write("Data de fabricação (DD/MM/YYYY): ");
                DateTime dataFabricacao;
                while (!DateTime.TryParse(Console.ReadLine(), out dataFabricacao))
                {
                    Console.Write("Data inválida. Digite novamente (DD/MM/YYYY): ");
                }
                list.Add(new ProdutoUsado(nome, preco, dataFabricacao));
            }
            else
            {
                Console.Write("Taxa alfandegária: ");
                double taxaAlfandegaria;
                while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out taxaAlfandegaria) || taxaAlfandegaria < 0)
                {
                    Console.WriteLine("Taxa inválida. Digite novamente: ");
                }
                list.Add(new ProdutoImportado(nome, preco, taxaAlfandegaria));
            }

            i++;
        }

        Console.WriteLine("\nETIQUETAS DE PREÇO:");
        foreach (Produto prod in list)
        {
            Console.WriteLine(prod.PrecoFinal().ToString());
        }
    }
}
