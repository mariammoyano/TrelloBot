using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrelloTasker.Model.DTO;

namespace TrelloTasker.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrelloWebhookController : ControllerBase
    {
    
        private readonly ILogger<TrelloWebhookController> logger;

        public TrelloWebhookController(ILogger<TrelloWebhookController> logger)
        {
            this.logger = logger;
        }
    
        [HttpPost()]
        public async Task<IActionResult> OnWebhookCallback(TrelloWebHookDTO trelloWebhookDTO)
        {
            logger.LogInformation(Request.Body.ToString(), Request);

            // if (trelloWebhookDTO.action.data.card.name.EndsWith("Bi-daily"))
            // {
            //     throw new NotImplementedException();
            // }
            return new OkObjectResult(trelloWebhookDTO);
        }
    }
}
