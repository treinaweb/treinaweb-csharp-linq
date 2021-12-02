using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_02_Where
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Descricao = "Arroz", Categoria = "Cereais", Preco = 4.89m },
            new Produto { Descricao = "Feijão", Categoria = "Cereais", Preco = 8.19m },
            new Produto { Descricao = "Detergente", Categoria = "Limpeza", Preco = 2.29m },
            new Produto { Descricao = "Desinfetante", Categoria = "Limpeza", Preco = 3.99m }
        };

        static void Main(string[] args)
        {
            //var resultado = produtos.Where(p => p.Preco < 5);
            // var resultado = produtos.Where(p => p.Categoria == "Cereais");
            var resultado = produtos.Where(p => p.Descricao.Contains("De") && p.Preco < 3);

            foreach (var r in resultado)
            {
                Console.WriteLine(r);
            }
        }
    }
}
