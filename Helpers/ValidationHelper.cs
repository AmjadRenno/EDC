using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EDC.Helpers
{
    public static class ValidationHelper
    {
        public static ValidationResult ValidateRealtor(string firstName, string lastName, string phone, string email)
        {
            var errors = new List<string>();

            // Validate FirstName
            if (string.IsNullOrWhiteSpace(firstName))
                errors.Add("Fornavn er påkrævet");
            else if (firstName.Length < 2)
                errors.Add("Fornavn skal være mindst 2 tegn");
            else if (!IsValidName(firstName))
                errors.Add("Fornavn må kun indeholde bogstaver");

            // Validate LastName
            if (string.IsNullOrWhiteSpace(lastName))
                errors.Add("Efternavn er påkrævet");
            else if (lastName.Length < 2)
                errors.Add("Efternavn skal være mindst 2 tegn");
            else if (!IsValidName(lastName))
                errors.Add("Efternavn må kun indeholde bogstaver");

            // Validate Phone
            if (string.IsNullOrWhiteSpace(phone))
                errors.Add("Telefonnummer er påkrævet");
            else if (!IsValidDanishPhone(phone))
                errors.Add("Telefonnummer er ikke gyldigt (8 cifre forventet)");

            // Validate Email
            if (string.IsNullOrWhiteSpace(email))
                errors.Add("Email er påkrævet");
            else if (!IsValidEmail(email))
                errors.Add("Email er ikke gyldig");

            return new ValidationResult(errors.Count == 0, errors);
        }

        private static bool IsValidName(string name)
        {
            // Allow letters, spaces, hyphens, and common Danish characters
            return Regex.IsMatch(name, @"^[a-zA-ZæøåÆØÅ\s\-']+$");
        }

        private static bool IsValidDanishPhone(string phone)
        {
            // Remove spaces and common separators
            var cleanPhone = Regex.Replace(phone, @"[\s\-\(\)]", "");
            
            // Danish phone numbers are typically 8 digits
            return Regex.IsMatch(cleanPhone, @"^\d{8}$");
        }

        private static bool IsValidEmail(string email)
        {
            try
            {
                var emailAttribute = new EmailAddressAttribute();
                return emailAttribute.IsValid(email);
            }
            catch
            {
                return false;
            }
        }
    }

    public class ValidationResult
    {
        public bool IsValid { get; }
        public List<string> Errors { get; }

        public ValidationResult(bool isValid, List<string> errors)
        {
            IsValid = isValid;
            Errors = errors ?? new List<string>();
        }

        public string GetErrorMessage()
        {
            return string.Join("\n", Errors);
        }
    }
}
