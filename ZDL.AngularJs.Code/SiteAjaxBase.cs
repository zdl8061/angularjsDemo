/*----------------------------------------------------------------
 *  Copyright (C) 2015 天下商机（txooo.com）版权所有
 * 
 *  文 件 名：SiteAjaxBase
 *  所属项目：
 *  创建用户：张德良
 *  创建时间：2015/8/21 14:27:55
 *  
 *  功能描述：
 *          1、
 *          2、 
 * 
 *  修改标识：  
 *  修改描述：
 *  待 完 善：
 *          1、 
----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.SessionState;

namespace ZDL.AngularJs
{

    public class SiteAjaxBase : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string methodName = context.Request.PathInfo.Replace("/", "");

            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.Instance
                    | BindingFlags.IgnoreCase
                    | BindingFlags.NonPublic
                    | BindingFlags.Public);

            var fun = (Func<HttpContext, string>)method.CreateDelegate(typeof(Func<HttpContext, string>), this);
            context.Response.Write(fun(context));
        }

        protected string JSON(bool success, string msg, params string[] other)
        {
            var p = string.Empty;
            if (other.Length > 0)
            {
                p = "," + string.Join(",", other);
            }
            var result = string.Format("({{\"success\":\"{0}\",\"msg\":\"{1}\"{2}}})", success.ToString().ToLower(), msg, p);
            return result;
        }

        public bool IsReusable { get { return false; } }

    }
}
