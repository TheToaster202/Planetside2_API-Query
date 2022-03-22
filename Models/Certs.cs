using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{
    public class Certs
    {
        public string earned_points { get; set; }
        public string gifted_points { get; set; }
        public string spent_points { get; set; }
        public string available_points { get; set; }
        public string percent_to_next { get; set; }
    }
}