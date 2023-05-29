using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Auditorium
    {
        public int CinemaID { get; set; }
        public int AuditoriumID { get; set; }
    }
}