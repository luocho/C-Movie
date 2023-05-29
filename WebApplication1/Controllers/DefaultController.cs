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
    public class DefaultController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        // GET: api/Default
        //swiper轮播图片数据
        public Result Get()
        {
            var data = db.Query("SELECT * FROM movie ORDER BY MovieScore DESC LIMIT 5").ToList();
            if (data != null)
            {
                return Result.success(data);
            }
            return Result.error("404页面丢失");
        }

        // GET: api/Default/5
        //电影类型数据（正在热映、即将上映、经典影片）
        public Result Get(int id)
        {
            if (id == 1)
            {
                var data = db.Query("SELECT * FROM movie a JOIN moviestate b ON a.StateID=b.StateID WHERE a.StateID=" + id ).ToList();
                if (data != null) return Result.success(data);
                else return Result.error("404页面丢失");
            }
            else if (id == 2)
            {
                var data = db.Query("SELECT * FROM movie a JOIN moviestate b ON a.StateID=b.StateID WHERE a.StateID=" + id).ToList();
                if (data != null) return Result.success(data);
                else return Result.error("404页面丢失");
            }
            else
            {
                var data = db.Query("SELECT * FROM movie a JOIN moviestate b ON a.StateID=b.StateID WHERE a.StateID=" + id + " ORDER BY MovieScore DESC").ToList();
                if (data != null) return Result.success(data);
                else return Result.error("404页面丢失");
            }
        }

        // POST: api/Default
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
