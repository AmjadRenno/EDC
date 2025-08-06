using System;
using System.ComponentModel.DataAnnotations;

namespace EDC.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Titel er påkrævet")]
        [StringLength(100, ErrorMessage = "Titel må maksimalt være 100 tegn")]
        public required string Title { get; set; }

        [Required(ErrorMessage = "Adresse er påkrævet")]
        [StringLength(100, ErrorMessage = "Adresse må maksimalt være 100 tegn")]
        public required string Address { get; set; }

        [Required(ErrorMessage = "Postnummer er påkrævet")]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Postnummer skal være 4 cifre")]
        public required string PostalCode { get; set; }

        [Required(ErrorMessage = "By er påkrævet")]
        [StringLength(50, ErrorMessage = "By må maksimalt være 50 tegn")]
        public required string City { get; set; }

        [Required(ErrorMessage = "Boligtype er påkrævet")]
        public PropertyType Type { get; set; }

        [Required(ErrorMessage = "Størrelse er påkrævet")]
        [Range(1, 10000, ErrorMessage = "Størrelse skal være mellem 1 og 10000 m²")]
        public int SizeM2 { get; set; }

        [Required(ErrorMessage = "Antal værelser er påkrævet")]
        [Range(1, 50, ErrorMessage = "Antal værelser skal være mellem 1 og 50")]
        public int Rooms { get; set; }

        [Required(ErrorMessage = "Byggår er påkrævet")]
        [Range(1800, 2030, ErrorMessage = "Byggår skal være mellem 1800 og 2030")]
        public int YearBuilt { get; set; }

        [Required(ErrorMessage = "Salgspris er påkrævet")]
        [Range(100000, 100000000, ErrorMessage = "Salgspris skal være mellem 100.000 og 100.000.000 kr")]
        public decimal AskingPrice { get; set; }

        public decimal? SoldPrice { get; set; }
        public DateTime? SoldDate { get; set; }

        [Required(ErrorMessage = "Sælger er påkrævet")]
        public int SellerId { get; set; }

        [Required(ErrorMessage = "Ejendomsmægler er påkrævet")]
        public int RealtorId { get; set; }

        public int? BuyerId { get; set; }

        public PropertyStatus Status { get; set; } = PropertyStatus.ForSale;

        [StringLength(1000, ErrorMessage = "Beskrivelse må maksimalt være 1000 tegn")]
        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string FullAddress => $"{Address}, {PostalCode} {City}";
        
        public string PropertyTypeDisplay => Type switch
        {
            PropertyType.House => "Hus",
            PropertyType.Apartment => "Lejlighed",
            PropertyType.Townhouse => "Rækkehus",
            PropertyType.Villa => "Villa",
            PropertyType.Condominium => "Ejerlejlighed",
            _ => "Ukendt"
        };

        public string StatusDisplay => Status switch
        {
            PropertyStatus.ForSale => "Til salg",
            PropertyStatus.Sold => "Solgt",
            PropertyStatus.UnderOffer => "Under bud",
            PropertyStatus.Reserved => "Reserveret",
            _ => "Ukendt"
        };

        public decimal PricePerM2 => SizeM2 > 0 ? AskingPrice / SizeM2 : 0;
        
        public string FormattedPrice => AskingPrice.ToString("N0") + " DKK";
        
        public string FormattedPricePerM2 => PricePerM2.ToString("N0") + " DKK/m²";
        
        public int SquareMeters => SizeM2;
        public decimal Price => AskingPrice;
        public PropertyType PropertyType => Type;
        public DateTime ListingDate => CreatedAt;
    }

    public enum PropertyType
    {
        House,        // Hus
        Apartment,    // Lejlighed
        Townhouse,    // Rækkehus
        Villa,        // Villa
        Condominium   // Ejerlejlighed
    }

    public enum PropertyStatus
    {
        ForSale,      // Til salg
        Sold,         // Solgt
        UnderOffer,   // Under bud
        Reserved      // Reserveret
    }
}
