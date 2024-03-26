using Lab1.EShop.Web.Models.DomainModels;
using Microsoft.AspNetCore.Identity;

namespace Lab1.EShop.Web.Models.Identity
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<ConcertTicket>? ConcertTickets { get; set; }

        public string?  ConcertTicketId { get; set; }
    }
}
