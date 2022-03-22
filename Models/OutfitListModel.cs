using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{

    public class OutfitList
    {
        public string outfit_id { get; set; }
        public string name { get; set; }
        public List<Member> members { get; set; }
    }

    public class OutfitListRoot
    {
        public List<OutfitList> outfit_list { get; set; }
        public int returned { get; set; }
    }
}