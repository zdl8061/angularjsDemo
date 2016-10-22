/*----------------------------------------------------------------
 *  Copyright (C) 2015 天下商机（txooo.com）版权所有
 * 
 *  文 件 名：NewsInfo
 *  所属项目：
 *  创建用户：张德良
 *  创建时间：2015/8/21 14:00:25
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
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZDL.AngularJs.News.Entity
{
    [TxTable(Name = "jz_news_info", Base = "TxoooBrands")]
    public class NewsInfo
    {
        #region 属性


        private int m_newsId;
       
        [Column(Name = "news_id")]
        public int NewsId
        {
            get { return m_newsId; }
            set { m_newsId = value; }
        }


        private int m_brandId;
        [Column(Name = "brand_id")]
        
        public int BrandId
        {
            get { return m_brandId; }
            set { m_brandId = value; }
        }

        private string m_title;
        [Column(Name = "title")]
        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        private string m_newsImg;
        [Column(Name = "news_img")]
        public string NewsImg
        {
            get { return m_newsImg; }
            set { m_newsImg = value; }
        }

        private string m_newsContent;
        [Column(Name = "news_content")]
        public string NewsContent
        {
            get { return m_newsContent; }
            set { m_newsContent = value; }
        }

        private DateTime m_addTime;
        [Column(Name = "add_time")]
        public DateTime AddTime
        {
            get { return m_addTime; }
            set { m_addTime = value; }
        }
        #endregion	
    }
}
