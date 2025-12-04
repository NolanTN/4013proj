using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace _4013Project.Models
{
    public class Form : IValidatableObject
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Range(1, 5)]
        public int? Rating { get; set; }

        [Required, MinLength(40)]
        public string Feedback { get; set; }

        public string? LowRatingDetails { get; set; }

        // For messages:
        public string? StatusMessage { get; set; }
        public bool IsSuccess { get; set; }

        // Conditional rule: if Rating < 3, LowRatingDetails required
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Rating.HasValue && Rating.Value < 3 &&
                string.IsNullOrWhiteSpace(LowRatingDetails))
            {
                yield return new ValidationResult(
                    "Please tell us what we can improve when rating is less than 3.",
                    new[] { nameof(LowRatingDetails) }
                );
            }
        }
    }
}
