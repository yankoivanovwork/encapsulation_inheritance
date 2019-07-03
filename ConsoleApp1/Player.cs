using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player : PlayerController
    {
        public string PlayerName { get; set; }

        public void BasicAttack()
        {
            Console.WriteLine(PlayerName + " attacked the target with 1 damage.");
        }
        
        public void LeftKeyPressedMessage()
        {
            TurnLeft();
        }
    }
}
