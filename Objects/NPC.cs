using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class NPC
    {
        public NPC()
        {

        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string[] dialouge;
        public string[] Dialouge
        {
            get { return dialouge; }
            set { dialouge = value; }
        }
    }
}
