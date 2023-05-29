using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public int MovieDate { get; set; }
        public int MovieTime { get; set; }
        public string MovieType { get; set; }
        public string MIntroduce { get; set; }
        public string MovieActor { get; set; }
        public double MovieScore { get; set; }
        public double MovieGrossed { get; set; }
        public int CommentsID { get; set; }
        public string MovieArea { get; set; }
        public int StateID { get; set; }
        public string MovieImage { get; set; }
        public string ImageList { get; set; }
        public string ActorImage { get; set; }
    }
}