namespace Product.Domain.Entities;

public class CategoryVariation
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string VariationName { get; set; } = null!;

    public ProductCategory Category { get; set; } = null!;
    public ICollection<VariationValue> VariationValues { get; set; } = [];
}
