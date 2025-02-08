using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class MedicalCertificate
    {
        public Guid MedicalCertificateID { get; set; }

        public DateTime IssueDate { get; set; } = DateTime.UtcNow;

        [Required]
        public string Content { get; set; }

        public int DurationDays { get; set; }

        public Guid ConsultationID { get; set; }
        public Consultation Consultation { get; set; }
    }
}
