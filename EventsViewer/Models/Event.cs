﻿using System.ComponentModel.DataAnnotations;

namespace EventsViewer.Models
{
    public class Event
    {
        public int Id { get; set; }
        
        public string? EventTitle { get; set; }
        
        public string? Description { get; set; }
        
        public DateTime? Date { get; set; }
    }
}
