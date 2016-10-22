/*----------------------------------------------------------------
 *  Copyright (C) 2015 天下商机（txooo.com）版权所有
 * 
 *  文 件 名：SiteAjaxFactory
 *  所属项目：
 *  创建用户：张德良
 *  创建时间：2015/8/21 14:25:36
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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ZDL.AngularJs
{
    public class SiteAjaxFactory : IHttpHandlerFactory
    {
        public IHttpHandler GetHandler(HttpContext context, string requestType, string url, string pathTranslated)
        {
            var _path = Regex.Match(url, @"\/(.*?)\.ajax", RegexOptions.IgnoreCase);
            var _className = _path.Groups[1].Value.Replace('/', '.');

            Type handlerType = System.Web.Compilation.BuildManager.GetType(_className, false, true);
            var handler = Activator.CreateInstance(handlerType) as SiteAjaxBase;
            return handler;
        }


        public void ReleaseHandler(IHttpHandler handler)
        {
            
        }
    }
}
