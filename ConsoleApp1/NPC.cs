using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class NPC : BasicCharacterStats
    {
        private string name;

        public NPC(string npcName)
        {
            name = npcName;
        }

        public void Information()
        {
            Console.WriteLine("NPC with name: " + name + ", Aerage damage: " + damage);
        }
    }
}
