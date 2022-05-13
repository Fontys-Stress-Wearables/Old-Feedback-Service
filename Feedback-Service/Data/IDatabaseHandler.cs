using Feedback_Service.Models;

namespace Feedback_Service.Data
{
    public interface IDatabaseHandler
    {
        public List<FeedbackEntry> GetAllForPatient(Guid patientId);
        public FeedbackEntry GetById(Guid id);
        public void AddFeedbackEntry(FeedbackEntry entry);
    }
}
