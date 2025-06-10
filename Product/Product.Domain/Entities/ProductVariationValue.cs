namespace Product.Domain.Entities;

public class ProductVariationValue
{
    public int ProductId { get; set; }
    public int VariationValueId { get; set; }

    public Product Product { get; set; } = null!;
    public VariationValue VariationValue { get; set; } = null!;
}
