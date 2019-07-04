using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player : BasicCharacterStats
    {
        private readonly int specialAttackResourceCost = 45;
        private string name;
        private int maxResource;
        private int availableResource;

        public Player(string playerName)
        {
            name = playerName;
            maxResource = resourcePoints;
            availableResource = resourcePoints;
        }

        public void BasicAttack()
        {
            Console.WriteLine(name + " attacked the target with 100 damage.");
        }

        public void SpecialAttack()
        {
            if (availableResource > specialAttackResourceCost)
            {
                availableResource = SpendResourcePoints(specialAttackResourceCost);

                Console.WriteLine(name + " attacked the target with combo attack for 400 damage.");
            }
            else
            {
                Console.WriteLine("Not enough "+resourceType+" points, currently " + name + " has " + availableResource);
            }
        }

        private int SpendResourcePoints(int points)
        {
            if (points > 0 && points <= maxResource)
            {
                return availableResource - points;
            }
            return points;
        }
    }
}
