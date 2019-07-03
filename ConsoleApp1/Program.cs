using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //encapsulation
            //primer1
            Clock clock1 = new Clock();
            clock1.Hours = 22;
            clock1.Minutes = 10;
            Console.WriteLine("Set time is: " + clock1.Hours + ":" + clock1.Minutes);

            //primer2
            BusinessCard card1 = new BusinessCard();
            card1.Name = "Yanko";
            card1.FamilyName = "Ivanov";
            card1.Age = 26;
            Console.WriteLine(card1.ToString());

            //primer3
            Computer computer1 = new Computer("Ryzen 7 2700X", "NVIDIA RTX 2070", 32, "ASUS Prime X470-Pro", "Corsair HX750i 750W Platinum");
            Console.WriteLine(computer1.ToString());

            Console.WriteLine("-----------------------------");

            //Inheritance
            Player yanko1 = new Player();
            yanko1.PlayerName = "YankoIvanov";
            yanko1.MoveForward();
            yanko1.BasicAttack();
            yanko1.LeftKeyPressedMessage();

            Console.WriteLine();

            NPC npc1 = new NPC("NPC001");
            npc1.HealthPoints();
            npc1.ResourceType();
            npc1.Introduction();
        }
    }
}
