using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class DoctorsDbContext : DbContext
    {
        public DbSet<Doctor1> Doctors { get; set; }

        public DoctorsDbContext()
        {

        }

        public DoctorsDbContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor1>((builder) =>
            {
                //...
                builder.HasKey(e => e.IdDoctor);
                builder.Property(e => e.IdDoctor).ValueGeneratedOnAdd();
                builder.Property(e => e.FirstName).IsRequired();

                builder.HasMany(a => a.Prescriptions)
                       .WithOne(a => a.Doctor)
                       .HasForeignKey(a => a.IdDoctor)
                       .IsRequired();
            });


            modelBuilder.Entity<Prescription>((builder) =>
            {
                builder.HasKey(p => p.IdPrescription);
            });
        }
    }
}