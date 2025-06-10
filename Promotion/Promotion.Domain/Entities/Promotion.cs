namespace Promotion.Domain.Entities;

public class Promotion
{
    public int  Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Discount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public ICollection<PromotionDetails> PromotionDetails { get; set; } = [];
}