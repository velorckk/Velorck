using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyGame
{
    public class Hero
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public List<Item> Items { get; set; } = new List<Item> ();
        public int Hp { get; set; } = 100;
        public int Damage { get; set; } = 15;
        public int Hungry { get; set; } = 100;


        public Hero(string name, Point location)
        {
            Name = name;
            Location = location;
        }
    }
}
