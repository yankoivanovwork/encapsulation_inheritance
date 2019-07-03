using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PlayerController
    {
        public void MoveForward()
        {
            Console.WriteLine("Player moved forward one step");
        }

        protected void TurnLeft()
        {
            Console.WriteLine("Player turned left");
        }

        private void LoadKeyBindingsFromFile()
        {
            //------
        }
    }
}
