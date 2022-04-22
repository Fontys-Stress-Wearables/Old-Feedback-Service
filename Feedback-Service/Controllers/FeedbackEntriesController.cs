using Microsoft.AspNetCore.Mvc;

namespace Feedback_Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FeedbackEntriesController : ControllerBase
    {
        private readonly ILogger<FeedbackEntriesController> _logger;

        public FeedbackEntriesController(ILogger<FeedbackEntriesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFeedbackEntries")]
        public IEnumerable<String> Get()
        {
            List<String> result = new List<String>();
            result.Add("Hello 1");
            result.Add("Hello 2");
            return result;
        }
    }
}