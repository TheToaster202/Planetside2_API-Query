using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{
    public class OnlineStatus
    {
        public string online_status { get; set; }
        public OnlineStatusJoinWorld online_status_join_world { get; set; }
    }
}