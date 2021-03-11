using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGObjects
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<ItemProperty> properties;
        public List<ItemProperty> Properties
        {
            get { return properties; }
            set { properties = value; }
        }
    }
}
