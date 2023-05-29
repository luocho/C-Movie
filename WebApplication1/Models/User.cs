using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Serializable]
    public class User
    {
        public int UserID { get; set; }
        public string UserAccount { get; set; }
        public string UserPwd { get; set; }
        public DateTime UserBirth { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }
        public string UserAvatar { get; set; }
    }
}