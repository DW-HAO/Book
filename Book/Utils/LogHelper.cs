using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

namespace Book.Utils
{
    public static class LogHelper
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogHelper));

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Warn(string message)
        {
            log.Warn(message);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }

        public static void Fatal(string message)
        {
            log.Fatal(message);
        }
    }
}