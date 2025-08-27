using Email.Model.Requests;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Service.Email;

namespace Email.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("EmailPolicy")]
    public class EmailController : Controller
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            await _emailService.SendEmailAsync(request.Email);

            return Ok(new { message = "email sent" });
        }
    }
}
