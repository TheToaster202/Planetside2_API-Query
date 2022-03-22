using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{
    public class Times
    {
        public string creation { get; set; }
        public string creation_date { get; set; }
        public string last_save { get; set; }
        public string last_save_date { get; set; }
        public string last_login { get; set; }
        public string last_login_date { get; set; }
        public string login_count { get; set; }
        public string minutes_played { get; set; }
    }
}