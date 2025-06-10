namespace Order.Domain.Entities;

public class PaymentMethod
{
    public int Id { get; set; }
    public int PaymentTypeId { get; set; }
    public string Provider { get; set; } = null!;
    public string AccountNumber { get; set; } = null!;
    public DateTime Expiry { get; set; }
    public bool IsDefault { get; set; }

    public PaymentType PaymentType { get; set; } = null!;
}