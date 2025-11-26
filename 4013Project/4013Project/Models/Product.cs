using Microsoft.AspNetCore.Mvc;

namespace _4013Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
    }
}

