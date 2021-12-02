using System;

namespace _04_04_Expressoes_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> exibir = informacao => Console.WriteLine($"INFORMAÇÃO: {informacao}");
            exibir("Testando");

            Func<int, int, int> realizarOperacao = (a, b) => a + b;
            Console.WriteLine(realizarOperacao(1, 2));

            Predicate<int> verificar = a => a % 2 == 0;
            Console.WriteLine(verificar(1));
        }
    }
}
