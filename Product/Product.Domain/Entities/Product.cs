namespace Product.Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int CategoryId { get; set; }
    public decimal Price { get; set; }
    public int Qty { get; set; }
    public string ProductImage { get; set; } = null!;
    public string SKU { get; set; } = null!;

    public ProductCategory Category { get; set; } = null!;
    public ICollection<ProductVariationValue> ProductVariationValues { get; set; } = [];
}
