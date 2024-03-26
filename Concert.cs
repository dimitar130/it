using System.ComponentModel.DataAnnotations;

namespace Lab1.EShop.Web.Models.DomainModels
{
    public class Concert
    {
        public Guid Id { get; set; }

        [Required]
        public string? ConcertName { get; set; }

        [Required]
        public string? ConcertDate { get; set; }

        [Required]
        public string? ConcertPlace { get; set; }

        [Required]
        public int ConcertPrice { get; set; }

        public virtual ICollection<ConcertTicket>?  ConcertTickets { get; set; }

    }
}
