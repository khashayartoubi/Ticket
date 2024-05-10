using Microsoft.AspNetCore.Mvc;
using TicketService;
using TicketModel;



namespace TicketController
{
    [ApiController()]
    [Route("api/")]
    public class TicketControllers : ControllerBase
    {
        private readonly Tickets _ticketService;

        public TicketControllers(Tickets ticketService)
        {
            _ticketService = ticketService;
        }


        [HttpPost("create/{userId}")]
        public Ticket CreateTicket(int userId, [FromBody] Ticket ticketData)
        {
            return _ticketService.CreateTicket(ticketData, userId);
        }

        [HttpPost("answer/{ticketId}")]
        public ActionResult AnswerTicket(int ticketId, [FromBody] string answer)
        {
            _ticketService.AnswerTicket(ticketId, answer);
            return Ok("Ticket answered successfully.");
        }

    }
}
