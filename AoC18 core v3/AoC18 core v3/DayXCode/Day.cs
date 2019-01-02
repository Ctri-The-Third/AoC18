using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18.DayXCode
{
    interface Day
    {
        String getDefaultProblem();
        void Parse(String problem);
        String solvePart1();
        String solvePart2();
        


    }
}
