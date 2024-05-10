﻿namespace TicketModel
{
    public class Ticket
    {
        public int id { get; set; }
        public int userId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Answer { get; set; } 
        public bool IsAnswered { get; set; } = false;

    }
}
