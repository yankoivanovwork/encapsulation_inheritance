using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Clock
    {
        private int hours;
        private int minutes;

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
        }
    }
}
