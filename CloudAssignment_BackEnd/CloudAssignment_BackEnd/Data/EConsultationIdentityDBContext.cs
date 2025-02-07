using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CloudAssignment_BackEnd.Data
{
    public class EConsultationIdentityDBContext : IdentityDbContext
    {
        public EConsultationIdentityDBContext(DbContextOptions<EConsultationIdentityDBContext> options) : base(options)
        {

        }

        // Seed Some Roles in the Database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var doctorRoleID = "8edfbd05-9fa6-4f12-8aa5-8a940b2eb0c5";
            var patientRoleID = "f95ffe20-1ee6-41a0-b6a3-3cbf8d2a4d3b";
            var adminRoleID = "edd731a5-22a6-4ef6-8c58-325ae735cb0c";
            var receptionistID = "17199d0b-194b-408b-a2e2-3c650abe436f";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = doctorRoleID,
                    ConcurrencyStamp = doctorRoleID,
                    Name = "Doctor",
                    NormalizedName = "DOCTOR"
                },
                new IdentityRole
                {
                    Id = patientRoleID,
                    ConcurrencyStamp = patientRoleID,
                    Name = "Patient",
                    NormalizedName = "PATIENT"
                },
                new IdentityRole
                {
                    Id = adminRoleID,
                    ConcurrencyStamp = adminRoleID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = receptionistID,
                    ConcurrencyStamp = receptionistID,
                    Name = "Receptionist",
                    NormalizedName = "RECEPTIONIST"
                }
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);
        }
    } 
}
