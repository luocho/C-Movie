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
using System.Text;

namespace WebApplication1.Controllers
{
    public class CreateController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        StringBuilder sb = new StringBuilder();
        // GET: api/Create
        public void Get()
        {

        }

        // GET: api/Create/5
        public Result Get(string UserAccount)
        {
            sb.Clear();
            sb.AppendFormat("SELECT * FROM `cinemawebdata`.`user` WHERE UserAccount='{0}'",UserAccount);
            var user = db.Query(sb.ToString()).ToList();
            if (user.Count>0)
            {
                return Result.error("已有此用户");
            }
            else
            {
                return Result.success();
            }
        }

        // POST: api/Create
        public Result Post(User user)
        {
            int row;
            try
            {
                sb.Clear();
                sb.AppendFormat("INSERT INTO `user` (`UserAccount`, `UserPwd`, `UserBirth`, `UserName`, `Sex`, `UserAvatar`) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", user.UserAccount, user.UserPwd, user.UserBirth, user.UserName, user.Sex, user.UserAvatar);
                row = db.Execute(sb.ToString());
            }
            catch (Exception)
            {
                return Result.error("数据格式有误");
                throw;
            }
            
            if (row > 0) {
                return Result.success();
            }
            else
            {
                return Result.error("添加失败");
            }
        }

        // PUT: api/Create/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Create/5
        public void Delete(int id)
        {
        }
    }
}
