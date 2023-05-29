using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Comments
    {
        public int CommentsID { get; set; }
        public string Content { get; set; }
        public int UserID { get; set; }
        public DateTime CommentsDate { get; set; }
        public int Hits { get; set; }
    }
}