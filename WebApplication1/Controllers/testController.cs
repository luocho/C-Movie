using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using Dapper;


namespace WebApplication1.Controllers
{
    public class testController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        // GET: api/test
        //查询电影表的数据
        public Result Get()
        {
            return Result.error("沙雕周周");
        }

        // GET: api/test/5
        public Result Get(int id)
        {
            string sql = "SELECT * FROM `cinemawebdata`.`test` where id=" + id;
           var hh= db.Query(sql).ToList();
            if (hh.Count==0)
            {
                return Result.error("你查找的这个id不存在");
            }
            else
            {
                return Result.success(hh);
            }
        }

        // POST: api/test
        public void Post()
        {
        }

        // PUT: api/test/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/test/5
        public void Delete(int id)
        {
        }
    }
}
