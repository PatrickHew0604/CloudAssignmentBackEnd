using CloudAssignment_BackEnd.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CloudAssignment_BackEnd.Data
{
    public class EConsultationDBContext : DbContext
    {
        public EConsultationDBContext(DbContextOptions<EConsultationDBContext> options) : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<MedicalCertificate> MedicalCertificates { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Address> Addresss { get; set; }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prescription>()
                .HasKey(p => new { p.ConsultationID, p.MedicationID }); // Composite Primary Key

            // Define Foreign Key Relationships
            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Consultation)
                .WithMany(c => c.Prescriptions)
                .HasForeignKey(p => p.ConsultationID);

            modelBuilder.Entity<Prescription>()
                .HasOne(p => p.Medication)
                .WithMany()
                .HasForeignKey(p => p.MedicationID);
        }
    }
}
