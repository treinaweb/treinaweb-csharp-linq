using System;

namespace _04_02_Multicast_Delegates
{
    public delegate void Notificacao(string mensagem);
    class Program
    {
        static void Main(string[] args)
        {
            Notificacao notificacao = new Notificacao(NotificarPorEmail);
            notificacao += NotificarPorWhatsApp;
            notificacao += NotificarPorSMS;

            // notificacao("TESTE");
            //ou
            notificacao.Invoke("TESTE");

            notificacao -= NotificarPorEmail;
            notificacao.Invoke("TESTE2");
        }

        static void NotificarPorEmail(string mensagem)
        {
            Console.WriteLine($"Enviando por e-mail: { mensagem }");
        }

        static void NotificarPorWhatsApp(string mensagem)
        {
            Console.WriteLine($"Enviando por WhatsApp: { mensagem }");
        }

        static void NotificarPorSMS(string mensagem)
        {
            Console.WriteLine($"Enviando por SMS: { mensagem }");
        }
    }
}
