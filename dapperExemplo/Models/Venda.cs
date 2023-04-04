namespace Models;

public class Venda{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public Vendedor Vendedor { get; set; }
    public List<ItemVenda>  ItensVenda { get; set; }
}