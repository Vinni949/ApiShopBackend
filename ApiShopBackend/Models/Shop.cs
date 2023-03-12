﻿namespace ApiShopBackend.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<Organization> organizations { get; set; }
    }
}