using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Seat
    {
        public int AuditoriumID { get; set; }
        public int ScenesID { get; set; }
        public int MovieID { get; set; }
        public string Seats { get; set; }
    }
}