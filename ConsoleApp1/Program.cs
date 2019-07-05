//reference v referenciite i using ...; classa ot drugo assembly e dostapen
using ProtectedInternal_InternalTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //inherit ProtectedInternal_InternalTesting.Employee + added reference
    public class Program : Employee
    {
        static void Main(string[] args)
        {
            //encapsulation
            //primer1
            Clock clock1 = new Clock();
            clock1.Hours = 22;
            clock1.Minutes = 10;
            Console.WriteLine("Set time is: " + clock1.Hours + ":" + clock1.Minutes);

            Console.WriteLine("-----------------------------");

            //primer2
            BusinessCard card1 = new BusinessCard();
            card1.Name = "Yanko";
            card1.FamilyName = "Ivanov";
            card1.Age = 26;
            Console.WriteLine(card1.ToString());

            Console.WriteLine("-----------------------------");

            //primer3 - using firstEmployeeName from ProtectedInternal_InternalTesting.Employee
            Program employeeName = new Program();
            Computer computer1 = new Computer(employeeName.FirstEmployeeName, "Ryzen 7 2700X", "NVIDIA RTX 2070", 32, "ASUS Prime X470-Pro", "Corsair HX750i 750W Platinum");
            Console.WriteLine(computer1.ToString());

            Console.WriteLine("-----------------------------");

            //Inheritance
            //primer1
            Player yanko1 = new Player("YankoIvanov");
            yanko1.HealthPoints();
            yanko1.ResourceType();
            yanko1.BasicAttack();
            yanko1.SpecialAttack();
            yanko1.SpecialAttack();
            yanko1.SpecialAttack();

            Console.WriteLine("-----------------------------");

            //primer2
            NPC npc1 = new NPC("NPC001");
            npc1.HealthPoints();
            npc1.ResourceType();
            npc1.Information();

            Console.WriteLine("-----------------------------");

            /*Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
            }*/
        }
    }
}
