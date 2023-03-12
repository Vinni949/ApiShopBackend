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
        public List<string>? Purchases { get; set; }

        public Organization(string Name,string? Adress,string? Email,string? Phone)
        {
            this.Name = Name;
            this.Adress = Adress;
            this.Email = Email;
            this.Phone = Phone;
            this.Orders = new List<Order>();
            this.Purchases= new List<string>();
        }
    }
}
