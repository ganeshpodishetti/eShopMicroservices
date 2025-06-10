namespace Shipping.Domain.Entities;

public class ShippingDetails
{
    public int Id { get; set; }
    public int ShipperId { get; set; }
    public int OrderId { get; set; }
    public string TrackingNumber { get; set; } = null!;
    public string ShippingStatus { get; set; } = null!;
}