using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class SmallAddress
    {
        public int SmallAddressID { get; set; }
        public string SmallAddressName { get; set; }
        public int BigAddressID { get; set; }
    }
}