using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    /// <summary>
    /// 创建外部辅助器方法
    /// </summary>
    public static class CustomerHelper
    {
        public static MvcHtmlString ListArrayItems(this HtmlHelper html,string [] list)
        {
            TagBuilder tag=new TagBuilder("ul");//创建ul标签
            foreach (string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");//创建li标签
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }
            return new MvcHtmlString(tag.ToString());
        }
        public static MvcHtmlString DisplayMessage(this HtmlHelper html,string msg)
        {
            string encodeMessage=html.Encode(msg);
            string result = string.Format("This is the message:<p>{0}</p>",encodeMessage);
            return new MvcHtmlString(result);
        }
    }
}