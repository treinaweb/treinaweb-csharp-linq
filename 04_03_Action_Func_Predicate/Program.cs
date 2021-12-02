using System;

namespace _04_02_Action_Func_Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> exibir = ExibirInformacao;
            exibir("Testando");

            Func<int, int, int> realizarOperacao = Somar;
            Console.WriteLine(realizarOperacao(1, 2));

            Predicate<int> verificar = EhPar;
            Console.WriteLine(verificar(1));
        }

        static void ExibirInformacao(string informacao)
        {
            Console.WriteLine($"INFORMAÇÃO: {informacao}");
        }

        static int Somar(int a, int b)
        {
            return a + b;
        }

        static bool EhPar(int a)
        {
            return a % 2 == 0;
        }
    }
}
