namespace Product.Domain.Entities;

public class VariationValue
{
    public int Id { get; set; }
    public int VariationId { get; set; }
    public string Value { get; set; } = null!;

    public CategoryVariation Variation { get; set; } = null!;
    public ICollection<ProductVariationValue> ProductVariationValues { get; set; } = [];
}
