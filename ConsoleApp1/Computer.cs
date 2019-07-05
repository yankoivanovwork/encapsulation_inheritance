using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Computer
    {
        private string nameOfEmployee;
        private string cpu;
        private string gpu;
        private double ram;
        private string motherboard;
        //protected internal int fanNumber;
        //protected bool rgb;
        private string supply;

        //propertyta s vseki modifikator i v drug klas kak rabotqt

        public Computer(string employeeName, string cpuInfo, string gpuInfo, double ramAmount, string motherboardName, string powerSupply)
        {
            nameOfEmployee = employeeName;
            cpu = cpuInfo;
            gpu = gpuInfo;
            ram = ramAmount;
            motherboard = motherboardName;
            supply = powerSupply;
        }

        public override string ToString()
        {
            return nameOfEmployee + " installed a desctop computer with - Processor: " + cpu + ", Graphics card: " + gpu + ", Ram amount: " + ram + "GB" + Environment.NewLine + "Motherboard: " + motherboard + ", Power supply: " + supply;
        }
    }
}
