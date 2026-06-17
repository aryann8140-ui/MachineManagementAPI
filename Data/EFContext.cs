using System.Reflection.PortableExecutable;
using MachineManagementAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MachineManagementAPI.Data
{

    public class EFContext : DbContext
    {
        private readonly IConfiguration _config;

        public EFContext(IConfiguration config)
        {
            _config = config;
        }
    public DbSet<MachineManagementAPI.Models.Machine> Machine{get; set;}
    public DbSet<MaintenanceLog> MaintenanceLog{get; set;}
    public DbSet<Operator> Operator{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_config.GetConnectionString("DefaultConnection"),
                optionsBuilder => optionsBuilder.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MachineManagementDatabase");

            modelBuilder.Entity<MachineManagementAPI.Models.Machine>(entity =>
            {
                entity.ToTable("Machines");
                entity.HasKey(m => m.Id);

                entity.HasMany(m => m.Operators)
                      .WithOne(o => o.Machine)
                      .HasForeignKey(m => m.AssignedMachineId);

                    entity.HasMany(m => m.MaintenanceLogs)
                        .WithOne(l => l.Machine)
                        .HasForeignKey(l => l.MachineId);
                });

            modelBuilder.Entity<MaintenanceLog>(entity =>
            {
                entity.HasKey(l => l.Id);
            });

            
            modelBuilder.Entity<Operator>(entity =>
            {
                entity.HasKey(o => o.Id);
            });
            






            
            
            
        }



    }
}