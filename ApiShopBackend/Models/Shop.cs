namespace ApiShopBackend.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Organization>? Organizations { get; set; }
        
        public Shop(string Name,string? Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Organizations=new List<Organization>();
        }
    }
}
