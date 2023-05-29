using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class Admin
    {
        public int AdminID { get; set; }
        public string AdminName { get; set; }
        public string AdminPwd { get; set; }
        public int AdminState { get; set; }
        public int CinemaID { get; set; }
    }
}