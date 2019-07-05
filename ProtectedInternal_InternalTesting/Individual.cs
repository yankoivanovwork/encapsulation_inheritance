using System;
using System.Collections.Generic;
using System.Text;

namespace ProtectedInternal_InternalTesting
{
    public class Individual : Employee
    {
        public void IntroduceMyself()
        {
            Console.WriteLine(FourthEmployeeName + " and " + FirstEmployeeName + " work together as a team.");
        }
    }
}
