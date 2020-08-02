using Microsoft.AspNetCore.Identity;

namespace InventoryApp.Database.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
