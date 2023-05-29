using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class CinemaMovie
    {
        public int MovieID { get; set; }
        public int CinemaID { get; set; }

        public int MoviePrice { get; set; }

        public string Imagery { get; set; }

        public string MovieLanguage { get; set; }
    }
}