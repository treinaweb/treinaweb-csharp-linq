using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_03_First_Single_Last
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>
        {
            new Produto { Descricao = "Arroz", Categoria = "Cereais", Preco = 4.89m },
            new Produto { Descricao = "Feijão", Categoria = "Cereais", Preco = 8.19m },
            new Produto { Descricao = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
            new Produto { Descricao = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
        };

        static void Main(string[] args)
        {
            var primeiro = produtos.First(p => p.Descricao.Contains("De"));
            var ultimo = produtos.Last(p => p.Descricao.Contains("De"));
            var arroz = produtos.Single(p => p.Descricao == "Arroz");

            Console.WriteLine(arroz);
        }
    }
}
