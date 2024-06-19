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
        /// ���������
        /// ִֻ��һ��
        /// ��վ��ʼ������
        /// ÿ30����һ��
        /// 
        /// Ϊ����վ�����е�ʱ�� ����Ҫ�������װ��
        /// </summary>
        protected void Application_Start()
        {
            // ע������
            AreaRegistration.RegisterAllAreas();
            // ע��ȫ�ֹ�����
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            // ע��·��
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            // ע��bundles--����js css��Ҫ�����
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // ע��log4net
            XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/CfgFiles/log4net.config")));
        }
    }
}
