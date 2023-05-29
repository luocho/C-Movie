using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using Dapper;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace WebApplication1.Controllers
{
    public class LoginController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        // GET: api/Login
        public void Get()
        {
            
        }

        // GET: api/Login/5
        public void Get(int id)
        {

        }

        // POST: api/Login
        public Result Post(User user)
        {
            string sql = string.Format("SELECT * FROM `cinemawebdata`.`user` WHERE UserAccount='{0}' AND UserPwd='{1}'", user.UserAccount, user.UserPwd);
            var userdata = db.Query(sql).ToList();
            if (userdata.Count > 0)
            {
                return Result.success(userdata);
            }
            else
            {
                return Result.error("账号或密码错误");
            }
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
