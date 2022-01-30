using System.ComponentModel.DataAnnotations;

namespace Practice_1.Models.DTOs
{
    public class CreatePersonDTO
    {
        [Required]
        [StringLength(11, MinimumLength = 11)]
        public string PersonalNumber { get; set; }

        [Required]
        [RegularExpression(@"^[ა-ჰ]+$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression(@"^[ა-ჰ]+$")]
        public string LastName { get; set; }

        [Required]
        [Range(13,19)]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@(gmail|yahoo+)((\.com)+)$", ErrorMessage = "You must enter gmail or yahoo's gmail.")]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [CreditCard]
        public string BankCard { get; set; }

        [Url]
        public string PersonalWebsite { get; set; }
    }
}
