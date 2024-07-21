using System;

namespace HireHub.Models
{
    public class Shade
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Shade(int id, string name, string brand, string description, int quantity, decimal price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Description = description;
            Quantity = quantity;
            Price = price;
        }
    }
}