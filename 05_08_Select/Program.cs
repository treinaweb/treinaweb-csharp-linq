using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_08_Select
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
            var resultado = produtos.Select(p => p.Descricao);

            foreach (var p in resultado)
            {
                Console.WriteLine(p);
            }
        }
    }
}
