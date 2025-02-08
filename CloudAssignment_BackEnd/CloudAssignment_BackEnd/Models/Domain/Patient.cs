using System;
using System.ComponentModel.DataAnnotations;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Patient
    {
        [Key]
        public string Username { get; set; }

        public string Name { get; set; }

        public string IdentityCardNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string EmergencyContact { get; set; }

        public Guid UploadedIdentityCardImageID { get; set; }

        public Guid AddressID { get; set; }

        // Navigation Properties
        public Image UploadedIdentityCardImage { get; set; }
        public Address Address { get; set; }

    }
}