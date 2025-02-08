namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Prescription
    {
        // Foreign keys
        public Guid ConsultationID { get; set; }
        public Guid MedicationID { get; set; }

        // Additional properties
        public string Dosage { get; set; }  // e.g., "1 tablet twice a day"
        public int Quantity { get; set; }  // Number of units prescribed

        // Navigation properties
        public Consultation Consultation { get; set; }
        public Medication Medication { get; set; }
    }
}
