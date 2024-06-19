using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Book
{
    
    public class MvcApplication : System.Web.HttpApplication
    {
        /// <summary>
        /// 主程序入库
        /// 只执行一次
        /// 网站初始化动作
        /// 每30分钟一次
        /// 
        /// 为了网站在运行的时候 把需要的组件都装配
        /// </summary>
        protected void Application_Start()
        {
            // 注册区域
            AreaRegistration.RegisterAllAreas();
            // 注册全局过滤器
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // 注册路由
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // 注册bundles--引用js css需要的组件
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // 注册log4net
            XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/CfgFiles/log4net.config")));
        }
    }
}
