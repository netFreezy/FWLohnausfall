using Microsoft.EntityFrameworkCore;

namespace Lohnausfall.Core.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Member>? Members { get; set; }
        public DbSet<Residence>? Residences { get; set; }
        public string? DbPath { get; }

        public ApplicationDBContext()
        {
            DbPath = @$"{AppDomain.CurrentDomain.BaseDirectory}fw_members.db;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasOne(e => e.Residence)
                .WithMany(e => e.Members)
                .HasForeignKey(e => e.ResidenceId)
                .IsRequired();
        }
    }
}