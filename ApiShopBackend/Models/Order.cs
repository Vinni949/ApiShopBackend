namespace ApiShopBackend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Organization Organization { get; set; }
        public string CounterpartyId { get; set; }
        public List<string>? PurchasesId { get; set; }
        public List<string>? PositionsId { get; set; }
        public string? Comment { get; set; }
    }
}
