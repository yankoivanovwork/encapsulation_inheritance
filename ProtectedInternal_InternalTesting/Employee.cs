using System;

namespace ProtectedInternal_InternalTesting
{
    public class Employee
    {
        private string firstEmployeeName = "Emilian";

        private string fourthEmployeeName = "Stamen";

        private string sixthEmployee = "Chicho mitko";

        protected internal string FirstEmployeeName
        {
            get
            {
                return firstEmployeeName;
            }
            set
            {
                firstEmployeeName = value;
            }
        }

        internal string FourthEmployeeName
        {
            get
            {
                return fourthEmployeeName;
            }
            set
            {
                fourthEmployeeName = value;
            }
        }

        public string SixthEmployee
        {
            get
            {
                return sixthEmployee;
            }
            set
            {
                sixthEmployee = value;
            }
        }
    }
}
