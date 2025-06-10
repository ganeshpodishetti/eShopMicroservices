namespace Promotion.Domain.Entities;

public class PromotionDetails
{
    public int Id { get; set; }
    public int PromotionId { get; set; }
    public Promotion Promotion { get; set; } = null!;
    public int ProductCategoryId { get; set; }
    public string ProductCategoryName { get; set; } = null!;
}