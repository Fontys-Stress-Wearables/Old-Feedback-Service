using Feedback_Service.Data;
using Feedback_Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feedback_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackEntriesController : ControllerBase
    {
        public AccessDatabaseHandler databaseHandler;

        public FeedbackEntriesController()
        {
            this.databaseHandler = new AccessDatabaseHandler();
        }

        [HttpGet("{patientId}")]
        public List<FeedbackEntry> GetAllForPatient(Guid patientId)
        {
            return databaseHandler.GetAllForPatient(patientId);
        }

        public void Create(Guid authorId, Guid stressMeasurementId, Guid patientId, string text)
        {
            FeedbackEntry feedbackEntry = new FeedbackEntry(authorId, stressMeasurementId, patientId, text);
            databaseHandler.AddFeedbackEntry(feedbackEntry);
        }
    }
}