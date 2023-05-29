using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class MovieScenes
    {
        public int ScenesID { get; set; }
        public int MovieID { get; set; }
        public int AuditoriumID { get; set; }
        public string PlayTime { get; set; }
    }
}