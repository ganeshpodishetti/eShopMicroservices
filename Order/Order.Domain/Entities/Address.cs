namespace Order.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string Street1 { get; set; } = null!;
    public string? Street2 { get; set; }
    public string City { get; set; } = null!;
    public string Zipcode { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;

    public ICollection<UserAddress> UserAddresses { get; set; } = [];
}