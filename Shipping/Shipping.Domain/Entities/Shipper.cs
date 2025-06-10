namespace Shipping.Domain.Entities;

public class Shipper
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string EmailId { get; set; } = null!;
    public string ContactPerson { get; set; } = null!;

    public ICollection<ShipperRegion> ShipperRegions { get; set; } = [];
    public ICollection<ShippingDetails> ShippingDetails { get; set; } = [];
}