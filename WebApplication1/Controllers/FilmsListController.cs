using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using Dapper;
using MySql.Data.MySqlClient;

namespace WebApplication1.Controllers
{
    public class FilmsListController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        // GET: api/FilmsList
        public Result Get()
        {
            var data = db.Query("SELECT * FROM moviestate").ToList();
            if (data != null)
            {
                return Result.success(data);
            }
            return Result.error("404页面丢失");
        }

        // GET: api/FilmsList/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/FilmsList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/FilmsList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/FilmsList/5
        public void Delete(int id)
        {
        }
    }
}
