using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyGame
{
    public class Item
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public Point Location { get; set; }
        public Button Button { get; set; }
        public int Hp { get; set; }
        public int Damage { get; set; } 
        public int Hungry { get; set; } 


        public Item(string name, string image, Point location )
        {
            Name = name;
            Image = image;
            Location = location;
        }
    }
}
