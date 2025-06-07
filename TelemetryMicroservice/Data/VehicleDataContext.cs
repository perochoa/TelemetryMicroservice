using TelemetryMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace TelemetryMicroservice.Data
{
    public class VehicleDataContext : DbContext
    {
        public VehicleDataContext(DbContextOptions<VehicleDataContext> options) : base(options) { }
        public DbSet<VehicleData> VehicleData { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleData>(entity =>
            {
                entity.HasIndex(e => e.VehicleID);
                entity.HasIndex(e => e.TimeStamp);
                entity.HasIndex(e => new { e.VehicleID, e.TimeStamp });
            });
        }
    }
}
