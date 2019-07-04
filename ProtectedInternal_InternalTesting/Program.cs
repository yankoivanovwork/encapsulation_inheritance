using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ProtectedInternal_InternalTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual();
            individual.IntroduceMyself();

            /*Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
            }*/
        }
    }
}
