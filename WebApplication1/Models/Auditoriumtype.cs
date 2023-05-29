using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Auditoriumtype
    {
        public int CinemaID { get; set; }
        public string AuditoriumType { get; set; }
    }
}