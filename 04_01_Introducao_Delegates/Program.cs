using System;

namespace _04_01_Introducao_Delegates
{
    delegate void ExibirMensagem(string texto);

    class Program
    {
        static void Main(string[] args)
        {
            ExibirMensagem exibir = ExibirInformacao;

            exibir("Testando");

            exibir = ExibirErro;

            exibir("Testando");
        }

        static void ExibirInformacao(string informacao)
        {
            Console.WriteLine($"INFORMAÇÃO: {informacao}");
        }
        
        static void ExibirErro(string informacao)
        {
            Console.WriteLine($"ERRO: {informacao}");
        }
    }
}
