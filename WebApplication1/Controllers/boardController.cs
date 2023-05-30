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
    public class boardController : ApiController
    {
        MySqlConnection db = new MySqlConnection("server=gz-cynosdbmysql-grp-j73nphjz.sql.tencentcdb.com;port=24123;user=root;password=Lcy1810205634;database=cinemawebdata;");
        StringBuilder sb = new StringBuilder();
        // GET: api/board
        public void Get()
        {

        }

        // GET: api/board/5
        public Result Get(int id)
        {
            sb.Clear();
            switch (id)
            {
                //请求的正在热映
                case 1:
                    sb.AppendLine("select * from movie where StateID=1 order by MovieScore limit 10");
                    break;
                case 2:
                    sb.AppendLine("select * from movie where StateID=2 order by MovieScore limit 10");
                    break;
                case 3:
                    sb.AppendLine("select * from movie where MovieArea like '中国大%' and StateID!=2 order by MovieGrossed desc");
                    break;
                case 4:
                    sb.AppendLine("select * from movie where MovieArea !='中国大陆' and StateID!=2 order by MovieGrossed desc");
                    break;
                case 5:
                    sb.AppendLine("select * from movie where StateID=1 order by MovieScore limit 10");
                    break;
                default:
                    break;
            }
            try
            {
                var movie = db.Query(sb.ToString()).ToList();
                return Result.success(movie);
            }
            catch (Exception)
            {
                return Result.error("请求失败！！id="+ id);
                throw;
            }
        }

        // POST: api/board
        public void Post(User user)
        {
            
        }

        // PUT: api/board/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/board/5
        public void Delete(int id)
        {
        }
    }
}
