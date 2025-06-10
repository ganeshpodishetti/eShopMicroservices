namespace Shipping.Domain.Entities;

public class ShipperRegion
{
    public int RegionId { get; set; }
    public Region Region { get; set; } = null!;
    public int ShipperId { get; set; }
    public Shipper Shipper { get; set; } = null!;
    public bool IsActive { get; set; } = true;
}