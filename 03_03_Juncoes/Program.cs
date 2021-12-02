using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_03_Juncoes
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Preco = 8000, Categoria = "Informatica" },
            new Produto { Nome = "Monitor", Preco = 1000, Categoria = "Informatica" },
            new Produto { Nome = "Cama", Preco = 2000, Categoria = "Moveis" },
            new Produto { Nome = "Armario", Preco = 3000, Categoria = "Moveis" }
        };

        private static List<Promocao> promocoes = new List<Promocao>
        {
            new Promocao { Categoria = "Informatica", Desconto = 10 },
            new Promocao { Categoria = "Moveis", Desconto = 20 }
        };

        static void Main(string[] args)
        {
            var resultado = from produto in produtos    
                            join promocao in promocoes on produto.Categoria equals promocao.Categoria
                            select new {
                                produto.Nome,
                                produto.Categoria,
                                PrecoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))
                            };

            foreach (var p in resultado)
            {
                Console.WriteLine($"{p.Nome} - {p.Categoria} - {p.PrecoComDesconto}");
            }
        }
    }
}
