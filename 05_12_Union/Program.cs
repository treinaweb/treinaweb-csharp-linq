using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_12_Union
{
    class Program
    {
        private static List<Conta> despesas = new List<Conta>
        {
            new Conta { Descricao = "Aluguel", Valor = 500, Vencimento = new DateTime(2021, 10, 01)},
            new Conta { Descricao = "Transporte", Valor = 300, Vencimento = new DateTime(2021, 10, 02)},
            new Conta { Descricao = "Alimentação", Valor = 200, Vencimento = new DateTime(2021, 10, 03)}
        };
        
        private static List<Conta> receitas = new List<Conta>
        {
            new Conta { Descricao = "Salário", Valor = 1500, Vencimento = new DateTime(2021, 10, 01)},
            new Conta { Descricao = "Investimentos", Valor = 100, Vencimento = new DateTime(2021, 10, 02)}
        };

        static void Main(string[] args)
        {
            var contas = despesas.Union(receitas);

            foreach (var c in contas)
            {
                Console.WriteLine(c);
            }
        }
    }
}
