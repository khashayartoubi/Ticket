namespace UserModel
{
    public class MUser
    {
        public int id { get; set; } // Assuming you'll have an auto-incremented ID
        public string Username { get; set; }
        public string Email { get; set; }
        public List<TicketModel.Ticket> Tickets { get; set; } // Collection of tickets for the user
    }
}
