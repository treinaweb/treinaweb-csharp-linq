namespace _05_03_First_Single_Last
{
    public class Produto
    {
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
    
        public override string ToString()
        {
            return $"{ Descricao } ({ Categoria }): { Preco }";
        }
    }
}