namespace Order.Domain.Entities;

public class ShoppingCart
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = null!;

    public Customer Customer { get; set; } = null!;
    public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; } = [];
}