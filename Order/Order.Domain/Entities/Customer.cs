namespace Order.Domain.Entities;

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Profile_PIC { get; set; } = null!;
    public string UserId { get; set; } = null!;

    public ICollection<UserAddress> UserAddresses { get; set; } = [];
    public ICollection<ShoppingCart> ShoppingCarts { get; set; } = [];
}