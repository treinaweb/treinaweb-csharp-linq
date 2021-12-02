using System;
using System.Linq;
using System.Collections.Generic;

namespace _05_09_Distinct
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
            var categorias = produtos.Select(p => p.Categoria).Distinct();

            foreach (var c in categorias)
            {
                Console.WriteLine(c);
            }
        }
    }
}
