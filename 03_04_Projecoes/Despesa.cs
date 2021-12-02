using System;

namespace _03_04_Projecoes
{
    public class Despesa
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString() => $"{Descricao.PadRight(20, ' ')} - {Vencimento.ToString("dd/MM/yyyy")} - {Valor}";
    }
}