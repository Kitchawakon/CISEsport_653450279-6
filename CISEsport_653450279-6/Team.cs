using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class Team
    {
        public string Team1 { get; set; }
        public string Name1 { get; set; }
        public string Gamename1 { get; set; }
        public string Name2 { get; set; }
        public string Gamename2 { get; set; }
        public string Name3 { get; set; }
        public string Gamename3 { get; set; }
        public string Name4 { get; set; }
        public string Gamename4 { get; set; }
        public string Name5 { get; set; }
        public string Gamename5 { get; set; }

        public Team(string team1, string name1, string gamename1, string name2, string gamename2, string name3, string gamename3, string name4, string gamename4, string name5, string gamename5)
        {
            Team1 = team1;
            Name1 = name1;
            Gamename1 = gamename1;
            Name2 = name2;
            Gamename2 = gamename2;
            Name3 = name3;
            Gamename3 = gamename3;
            Name4 = name4;
            Gamename4 = gamename4;
            Name5 = name5;
            Gamename5 = gamename5;
        }
    }
}
