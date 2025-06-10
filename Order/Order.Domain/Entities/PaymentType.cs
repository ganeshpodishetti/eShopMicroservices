namespace Order.Domain.Entities;

public class PaymentType
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<PaymentMethod> PaymentMethods { get; set; } = [];
}