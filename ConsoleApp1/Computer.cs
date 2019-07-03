using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Computer
    {
        public string gpu;
        public double ram;
        internal string motherboard;
        //protected internal int fanNumber;
        //protected bool rgb;
        private string cpu;
        private string supply;

        public Computer(string cpuInfo, string gpuInfo, double ramAmount, string motherboardName, string powerSupply)
        {
            cpu = cpuInfo;
            gpu = gpuInfo;
            ram = ramAmount;
            motherboard = motherboardName;
            supply = powerSupply;
        }

        public override string ToString()
        {
            return "Processor: " + cpu + ", Graphics card: " + gpu + ", Ram amount: " + ram + "GB" + Environment.NewLine + "Motherboard: " + motherboard + ", Power supply: " + supply;
        }
    }
}
