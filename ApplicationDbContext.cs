using Lab1.EShop.Web.Models.DomainModels;
using Lab1.EShop.Web.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1.EShop.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertTicket> ConcertsTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Concert>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ConcertTicket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();
          

            builder.Entity<ConcertTicket>()
                .HasOne(z => z.Concert)
                .WithMany(z => z.ConcertTickets)
                .HasForeignKey(z => z.ConcertId);

            builder.Entity<ConcertTicket>()
                .HasOne(z => z.Owner)
                .WithMany(z => z.ConcertTickets)
                .HasForeignKey(z => z.OwnerId);

            

        }
    }
}
