using System;

namespace _05_12_Union
{
    public class Conta
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public override string ToString() => $"{ Descricao.PadRight(20, ' ') } | { Vencimento.ToString("dd/MM/yyyy") } | { Valor.ToString("f").PadLeft(8, ' ') }";
    }
}