using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class Result
    {
        public int code { get; set; }//响应码，1 代表成功; 0 代表失败
        public String msg { get; set; } //响应信息 描述字符串
        public Object data { get; set; } //返回的数据

        public Result(int code, string msg, object data)
        {
            this.code = code;
            this.msg = msg;
            this.data = data;
        }

        public static  Result success(){
            return new Result(1,"success",null);
        }
        public static Result error(string msg)
        {
            return new Result(0,msg,null);
        }
        public static Result success(object data)
        {
            return new Result(1, "success", data);
        }

    }
}