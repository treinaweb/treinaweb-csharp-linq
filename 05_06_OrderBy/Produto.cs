namespace _05_06_OrderBy
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