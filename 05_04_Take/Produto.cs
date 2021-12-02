namespace _05_04_Take
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