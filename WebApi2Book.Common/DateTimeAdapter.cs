using System;
using log4net.Appender;

namespace WebApi2Book.Common
{
//    public interface IDateTime
//    {
//        DateTime UtcNow { get; }
//    }
    public class DateTimeAdapter : RollingFileAppender.IDateTime
    {
//        public DateTime UtcNow
//        {
//            get { return DateTime.UtcNow; }
//        }

        public DateTime Now => DateTime.Now;
    }
}