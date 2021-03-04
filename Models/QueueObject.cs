using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabSupportWebApp.Models
{
    public class QueueObject
    {
        public static string labName;
        public static string TeamsLink;

        public static int code;

        public static Queue<StudentUser> StudentsInQueue = new Queue<StudentUser>();



    }
}