using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Book
{
    public class RouteConfig
    {
        /// <summary>
        /// 进行路由规则声明
        /// 
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            // 忽略路由: 如果遇到xxx.axd/xxx 就不走这个路由匹配
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 路由规则是通过key value存储的
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
