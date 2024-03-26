using LabB.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace LabB.Web.Models.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
