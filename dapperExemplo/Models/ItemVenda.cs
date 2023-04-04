namespace Models;

public class ItemVenda{
    public int Id { get; set; }
    public double Qtd { get; set; }
    public double PrecoUnitario { get; set; }
    public Produto Produto { get; set; }
}