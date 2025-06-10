namespace Order.Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }
    public string CustomerName { get; set; } = null!;

    public int PaymentMethodId { get; set; }
    public string PaymentName { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;
    public string ShippingMethod { get; set; } = null!;
    public decimal BillAmount { get; set; }
    public string OrderStatus { get; set; } = null!;

    public ICollection<OrderDetails> OrderDetails { get; set; } = [];
}