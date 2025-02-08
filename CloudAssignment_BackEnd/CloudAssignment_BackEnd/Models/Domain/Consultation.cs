namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Consultation
    {
        public Guid ConsultationID { get; set; }

        public DateTime ConsultationDate { get; set; }

        public string Status { get; set; }

        // From AI
        public string PriorityLevel { get; set; }

        public string ClinicalNotes { get; set; }

        public string PreConsultData { get; set; } // JSON or string for pre-consultation data

        public bool RedFlagStatus { get; set; } // 1 - Urgent, 0 - Normal

        // Navigation Properties
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public List<Prescription> Prescriptions { get; set; } = new List<Prescription>();

    }
}
