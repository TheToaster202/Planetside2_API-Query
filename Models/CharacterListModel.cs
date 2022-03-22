using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIQuery.Models
{
    public class CharacterRoot
    {
        public List<CharacterList> character_list { get; set; }
        public int returned { get; set; }
    }

    public class CharacterList
    {
        public string character_id { get; set; }
        public Name name { get; set; }
        public string faction_id { get; set; }
        public string head_id { get; set; }
        public string title_id { get; set; }
        public Times times { get; set; }
        public Certs certs { get; set; }
        public BattleRank battle_rank { get; set; }
        public string profile_id { get; set; }
        public DailyRibbon daily_ribbon { get; set; }
        public string prestige_level { get; set; }
    }
    
}