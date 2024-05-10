
using TicketModel;

namespace TicketService
{
    public class Tickets
    {
        private readonly List<Ticket> _tickets;
        public Tickets()
        {
            _tickets = new List<Ticket>();
        }


        public Ticket CreateTicket(Ticket ticketData, int userId)
        {
            var newTicket = new Ticket
            {
                id = GenerateTicketId(),
                Title = ticketData.Title,
                Description = ticketData.Description,
                userId = userId
            };
            _tickets.Add(newTicket);
            return newTicket;
        }

        public void AnswerTicket(int ticketId, string answer)
        {
            var ticket = _tickets.Find(t => t.id == ticketId);
            if (ticket != null)
            {
                if (ticket.IsAnswered)
                {
                    throw new InvalidOperationException("This ticket has already been answered.");
                }
                ticket.Answer = answer;
                ticket.IsAnswered = true;
            }
            else
            {
                throw new ArgumentException("Ticket not found.");
            }
        }

        private int GenerateTicketId()
        {
            return _tickets.Count + 1;
        }
    }
}
