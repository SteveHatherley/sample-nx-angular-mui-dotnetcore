using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Init.Api
{
    public partial class Countdown
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Duration {get; set;}

        public bool complete {get; set;}
    }
}
