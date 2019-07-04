using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedInternal_InternalTesting
{
    public class Individual : Employee
    {
        public void IntroduceMyself()
        {
            Console.WriteLine(fourthEmployeeName + " and " + firstEmployeeName + " work together as a team.");
        }
    }
}
