using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class OrderState
    {
        public int OrderStateID { get; set; }
        public string OrderStateName { get; set; }
    }
}