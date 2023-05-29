using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class BigAddress
    {
        public int BigAddressID { get; set; }
        public string BigAddressName { get; set; }
        public string PinYin { get; set; }
        public int AddressHot { get; set; }
    }
}