﻿namespace ApiShopBackend.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public Organization Organization { get; set; }
        public Counterparty? Counterparty { get; set; }
        public List<string>? PurchasesId { get; set; }
        public List<Position>? PositionsId { get; set; }
        public string? Comment { get; set; }
    }
}
