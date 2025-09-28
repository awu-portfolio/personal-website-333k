using System;
using System.ComponentModel.DataAnnotations;

namespace Wu_Athena_EC.Models
{

    public class Event
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}