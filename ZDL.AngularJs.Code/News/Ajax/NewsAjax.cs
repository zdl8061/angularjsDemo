/*----------------------------------------------------------------
 *  Copyright (C) 2015 天下商机（txooo.com）版权所有
 * 
 *  文 件 名：NewsAjax
 *  所属项目：
 *  创建用户：张德良
 *  创建时间：2015/8/21 13:52:39
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
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using LitJson;
using Txooo.Web.Ajax;
using ZDL.AngularJs.News.Entity;

namespace ZDL.AngularJs.News.Ajax
{
    public class NewsAjax : SiteAjaxBase
    {
        public string GetList(HttpContext context)
        {
            int _count;
            var _newsList = TxData<NewsInfo>.Query(" where brand_id=@brand_id order by news_id desc ", out _count, 15, 0,
                paramValue: new object[] {2});

            //Thread.Sleep(4000);

            return JsonMapper.ToJson(_newsList, true);
        }
    }
}
