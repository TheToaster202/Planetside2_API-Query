using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{
    public class Member
    {
        public string character_id { get; set; }
        public string rank { get; set; }
        public Character character { get; set; }
    }
}