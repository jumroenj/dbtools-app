using DBTUserApiCloud.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DBTUserApiCloud.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TopicExecuteController : ControllerBase
    {

        private readonly ILogger<TopicExecuteController> _logger;

        public TopicExecuteController(ILogger<TopicExecuteController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "PostTopicExecute")]
        public IActionResult Post(TopicRequestModel request)
        {
            TopicResponseModel respoonse = new TopicResponseModel();
            if (request == null)
            {
                respoonse.STATUS = 0;
                respoonse.MESSAGE = "Invalid Request (request is null)";
            }
            else 
            {

                respoonse.STATUS = 1;
                respoonse.MESSAGE = "Topic " + request.TOPIC_ID + ":" + request.TOPIC_CODE + " Execute Success";

            }

            return Ok(new { results = respoonse });
        }
    }
}
