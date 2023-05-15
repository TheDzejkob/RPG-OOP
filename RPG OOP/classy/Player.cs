using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_OOP.classy;

namespace RPG_OOP.classy
{
    public class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Dmg { get; set; }
       public bool Friendly { get; set; }
       public int Stepcounter { get; set; }

        public double Multiplier { get; set; }

        public Player(string name, int hp, int dmg, bool friendly, int stepcounter, double multiplier)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
            Friendly = friendly;
            Stepcounter = stepcounter;
            Multiplier = multiplier;
        }

    }
}
