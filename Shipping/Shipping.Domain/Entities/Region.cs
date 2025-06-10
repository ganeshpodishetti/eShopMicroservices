namespace Shipping.Domain.Entities;

public class Region
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<ShipperRegion> ShipperRegions { get; set; } = [];
}