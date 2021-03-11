using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGObjects
{
    public class Player {
        public Player(string name)
        {
            this.Name = name;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Item> inventory;
        public List<Item> Inventory
        {
            get { return inventory; }
            set { inventory = value; }
        }
    }
}
