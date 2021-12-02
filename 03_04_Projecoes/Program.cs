using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_04_Projecoes
{
    class Program
    {
        private static List<Despesa> despesas = new List<Despesa>
        {
            new Despesa { Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021, 10, 1) },
            new Despesa { Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021, 10, 8) },
            new Despesa { Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021, 10, 18) },
            new Despesa { Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021, 10, 20) }
        };

        static void Main(string[] args)
        {
            var resultado = from d in despesas
                            select new { d.Descricao, ValorComDesconto = d.Valor * 0.9m };

            foreach (var r in resultado)
            {
                Console.WriteLine(r);
            }
        }
    }
}
