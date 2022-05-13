namespace Feedback_Service.Models
{
    public class FeedbackEntry
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public Guid StressMeasurementId { get; set; }
        public Guid PatientId { get; set; }
        public string Feedback { get; set; }

        public FeedbackEntry(Guid authorId, Guid stressMeasurementId, Guid patientId, string feedback)
        {
            Id = Guid.NewGuid();
            AuthorId = authorId;
            StressMeasurementId = stressMeasurementId;
            PatientId = patientId;
            Feedback = feedback;
        }

        public FeedbackEntry(Guid id, Guid authorId, Guid stressMeasurementId, Guid patientId, string feedback)
        {
            Id = id;
            AuthorId = authorId;
            StressMeasurementId = stressMeasurementId;
            PatientId = patientId;
            Feedback = feedback;
        }
    }
}
