namespace ApiShopBackend.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Organization Organization { get; set; }
        public Counterparty Counterparty { get; set; }
        public List<Position>? PositionsId { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
