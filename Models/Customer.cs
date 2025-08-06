using System;
using System.ComponentModel.DataAnnotations;

namespace EDC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Fornavn er påkrævet")]
        [StringLength(50, ErrorMessage = "Fornavn må maksimalt være 50 tegn")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Efternavn er påkrævet")]
        [StringLength(50, ErrorMessage = "Efternavn må maksimalt være 50 tegn")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Email er påkrævet")]
        [EmailAddress(ErrorMessage = "Ugyldig email format")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Telefon er påkrævet")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Telefonnummer skal være 8 cifre")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Adresse er påkrævet")]
        [StringLength(100, ErrorMessage = "Adresse må maksimalt være 100 tegn")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Postnummer er påkrævet")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postnummer skal være 4 cifre")]
        public required string PostalCode { get; set; }

        [Required(ErrorMessage = "By er påkrævet")]
        [StringLength(50, ErrorMessage = "By må maksimalt være 50 tegn")]
        public required string City { get; set; }

        [Required(ErrorMessage = "Fødselsdato er påkrævet")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Kundetype er påkrævet")]
        public CustomerType CustomerType { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string FullName => $"{FirstName} {LastName}";
        public string FullAddress => $"{Address}, {PostalCode} {City}";
        
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string CustomerTypeDisplay => CustomerType switch
        {
            CustomerType.Buyer => "Køber",
            CustomerType.Seller => "Sælger",
            _ => "Ukendt"
        };
    }

    public enum CustomerType
    {
        Buyer,   // Køber
        Seller   // Sælger
    }
}
