using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Score
    {
        public int MovieID { get; set; }
        public int UserID { get; set; }
        public double MovieScore { get; set; }
    }
}