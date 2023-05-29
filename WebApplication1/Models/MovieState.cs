using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class MovieState
    {
        public int StateID { get; set; }
        public string StateName { get; set; }
    }
}