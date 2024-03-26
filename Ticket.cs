using LabB.Web.Models.Identity;

namespace LabB.Web.Models.Domain
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public TheatreShow theatreShow { get; set; }
        public Guid theatreShowId { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string applicationUserId { get; set; }
    }
}
