using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_10_Count_Max_Min_Average
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Descricao = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m },
            new Produto { Descricao = "Feijão", Categoria = "Cereais", Preco = 8.19m },
            new Produto { Descricao = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
            new Produto { Descricao = "Arroz", Categoria = "Cereais", Preco = 4.89m },
        };

        static void Main(string[] args)
        {
            var quantidade = produtos.Count(p => p.Categoria == "Limpeza");
            var maximo = produtos.Max(p => p.Preco);
            var minimo = produtos.Min(p => p.Preco);
            var soma = produtos.Sum(p => p.Preco * 0.9m);
            var media = produtos.Average(p => p.Preco);
            Console.WriteLine(quantidade);
            Console.WriteLine(maximo);
            Console.WriteLine(minimo);
            Console.WriteLine(soma);
            Console.WriteLine(media);
        }
    }
}
