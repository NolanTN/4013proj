using Microsoft.AspNetCore.Mvc;

namespace _4013Project.Models
{
    public class StudentBusinessCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string ExternalUrl { get; set; }

    }
}
