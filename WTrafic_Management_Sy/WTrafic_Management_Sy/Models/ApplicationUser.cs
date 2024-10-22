using Microsoft.AspNetCore.Identity;

namespace WTrafic_Management_Sy.Models
{
    public class ApplicationUser : IdentityUser
    {
        // You can add additional properties here as needed
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // You can add more properties specific to your application
        // For example:
        // public DateTime DateOfBirth { get; set; }
        // public string ProfilePicture { get; set; }
    }
}
