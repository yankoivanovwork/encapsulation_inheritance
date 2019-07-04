using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicCharacterStats
    {
        protected readonly double healthPoints = 1000;
        protected readonly string resourceType = "Rage";
        protected readonly double damage = 25;
        protected readonly int resourcePoints = 100;

        public void HealthPoints()
        {
            Console.WriteLine("This character has HP: " + healthPoints);
        }

        public void ResourceType()
        {
            Console.WriteLine("This chacter has resource type: " + resourceType + " with " + resourcePoints + " available resource points.");
        }
    }
}
