using Lab1.EShop.Web.Models.Identity;

namespace Lab1.EShop.Web.Models.DomainModels
{
    public class ConcertTicket
    {
        public Guid Id { get; set; }
        public string? ConcertId { get; set; }

        public virtual Concert? Concert { get; set; }

        public string? OwnerId { get; set; }

        public virtual User? Owner { get; set; }

        public int NumberOfPeople { get; set; }
    }
}
