using Microsoft.AspNetCore.Identity;

namespace sklep.Models
{
    public class UserModel : IdentityUser
    {
        public string FullName { get; set; } // Dodatkowe pole - pełne imię i nazwisko
        public DateTime DateOfBirth { get; set; } // Data urodzenia
    }
}
