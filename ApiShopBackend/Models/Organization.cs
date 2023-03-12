namespace ApiShopBackend.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }   
        public string? Adress { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public List<Order>? Orders { get; set; }
        public List<string>? PurchasesId { get; set; }
    }
}
