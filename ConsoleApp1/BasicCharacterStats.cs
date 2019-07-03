using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BasicCharacterStats
    {
        protected readonly double healthPoints=1000;
        protected readonly string resourceType="Rage";
        protected readonly double damage=25;

        public void HealthPoints()
        {
            Console.WriteLine("Default HP: " + healthPoints);
        }

        public void ResourceType()
        {
            Console.WriteLine("Default Resource: " + resourceType);
        }
    }
}
