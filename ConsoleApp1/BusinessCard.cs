using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct BusinessCard
    {
        /*private string name;
        private string familyName;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string FamilyName
        {
            get
            {
                return familyName;
            }
            set
            {
                familyName = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }*/

        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "My name is " + Name + " " + FamilyName + " and I am " + Age + " years old.";
        }
    }
}
