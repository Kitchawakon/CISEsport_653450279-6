using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CISESPORT
{
    public class Player
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ID { get; set; }
        public string Field { get; set; }
        public string Gamename { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int Age { get; set; }
        public Player(string name, string lastname, string id, string field, string gamename, string email, string tel, int age)
        {
            Name = name;
            Lastname = lastname;
            ID = id;
            Field = field;
            Gamename = gamename;
            Email = email;
            Tel = tel;
            Age = age;
        }

    }
}
