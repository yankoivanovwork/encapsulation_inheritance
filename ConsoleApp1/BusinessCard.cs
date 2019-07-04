using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct BusinessCard
    {
        private string name;
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
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        private string MyInfo()
        {
            return "My name is " + Name + " " + FamilyName + ", " + Age + " years old and I am aprentice programmer.";
        }

        public override string ToString()
        {
            return "Basic business card information - " + MyInfo();
        }
    }
}
