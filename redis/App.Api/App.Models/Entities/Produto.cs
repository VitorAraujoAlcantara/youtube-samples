namespace App.Models.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public string? Codigo { get; set; }
        public double Preco { get; set; }
    }
}
