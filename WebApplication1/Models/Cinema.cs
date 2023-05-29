using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Cinema
    {
        public int CinemaID { get; set; }
        public string CinemaName { get; set; }
        public int SmallareaID { get; set; }
        public string CinemaAddress { get; set; }
        public string CinemaPhone { get; set; }
    }
}