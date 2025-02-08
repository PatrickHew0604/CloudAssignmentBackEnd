using System.ComponentModel.DataAnnotations.Schema;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Payment
    {
        public Guid PaymentID { get; set; }


        public string PaymentMethod { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        public Guid ConsultationID { get; set; }
        public Consultation Consultation { get; set; }
    }
}
