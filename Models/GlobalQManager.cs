using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabSupportWebApp.Models
{
    public class GlobalQManager
    {
        Dictionary<int, QueueObject> HashSet = new Dictionary<int, QueueObject>();

        public GlobalQManager()
        {

            QueueObject queueObject = new QueueObject();
            HashSet.Add(QueueObject.code, queueObject);
        }

    }

}
