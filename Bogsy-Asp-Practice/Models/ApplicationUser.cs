using Microsoft.AspNetCore.Identity;

namespace Bogsy_Asp_Practice.Models
{
    public class ApplicationUser : IdentityUser
    {
        //create attributes
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Address { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
