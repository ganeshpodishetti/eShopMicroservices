namespace Order.Domain.Entities;

public class ShoppingCartItem
{
    public int Id { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public int Qty { get; set; }
    public decimal Price { get; set; }

    public ShoppingCart ShoppingCart { get; set; } = null!;
}