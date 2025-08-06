using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.Models
{
    public class Realtor
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Fornavn er påkrævet")]
        public required string FirstName { get; set; }
        
        [Required(ErrorMessage = "Efternavn er påkrævet")]
        public required string LastName { get; set; }
        
        [Required(ErrorMessage = "Telefonnummer er påkrævet")]
        [Phone(ErrorMessage = "Telefonnummer er ikke gyldigt")]
        public required string Phone { get; set; }
        
        [Required(ErrorMessage = "Email er påkrævet")]
        [EmailAddress(ErrorMessage = "Email er ikke gyldig")]
        public required string Email { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
