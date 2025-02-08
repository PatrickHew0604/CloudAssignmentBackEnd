namespace CloudAssignment_BackEnd.Models.Domain
{
    public class Feedback
    {
        public Guid FeedbackID { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }

        public Guid ConsultationID { get; set; }
        public Consultation Consultation { get; set; }
    }
}
