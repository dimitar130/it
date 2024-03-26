using LabB.Web.Models.Domain;
using LabB.Web.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LabB.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<TheatreShow> TheatreShows { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<ApplicationUser> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TheatreShow>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Ticket>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();
            builder.Entity<Ticket>()
                .HasOne(t => t.theatreShow)
                .WithMany(c => c.Tickets)
                .HasForeignKey(t => t.theatreShowId);
            builder.Entity<Ticket>()
               .HasOne(t => t.applicationUser)
               .WithMany(c => c.Tickets)
               .HasForeignKey(t => t.applicationUserId);


        }
    }
}
