using System.ComponentModel.DataAnnotations;

namespace _4013Project.Models
{
    public class Apply
    {
        // ---- Company Info ----
        [Display(Name = "Company Type")]
        [Required(ErrorMessage = "Please select a company type.")]
        public string CompanyType { get; set; }   // "IBC" or "Independent"

        [Display(Name = "Link to Company Page")]
        [Url(ErrorMessage = "Please enter a valid URL.")]
        public string CompanyLink { get; set; }

        [Required, Display(Name = "Address")]
        public string Address { get; set; }

        [Required, Display(Name = "City")]
        public string City { get; set; }

        [Required, Display(Name = "State")]
        public string State { get; set; }

        [Required, Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Display(Name = "Phone Number")]
        [Phone]
        public string PhoneNumber { get; set; }

        // ---- Product Info ----
        [Required, Display(Name = "Brand Name")]
        public string BrandName { get; set; }

        [Required, Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Product Image URL")]
        public string ProductImageUrl { get; set; }   // or use IFormFile in controller

        [Required, Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required, Range(0, 1000000)]
        public decimal? Price { get; set; }
    }
}
