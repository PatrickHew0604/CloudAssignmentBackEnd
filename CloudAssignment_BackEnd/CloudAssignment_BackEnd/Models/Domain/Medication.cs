using System.ComponentModel.DataAnnotations.Schema;

namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Medication
    {
        public Guid MedicationID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string DosageForm { get; set; }

        public string Strength { get; set; }
    }
}
