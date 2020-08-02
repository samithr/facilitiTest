using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryApp.MVC.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the InventoryAppCUser class
    public class InventoryAppCUser : IdentityUser
    {
        [DisplayName("First Name")]
        [Column(TypeName="nvarchar(100)")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Column(TypeName = "nvarchar(100)")] 
        public string LastName { get; set; }
    }
}
