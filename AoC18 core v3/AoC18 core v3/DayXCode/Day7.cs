using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18.DayXCode
{
    public class Day7 : Day
    {
        public Dictionary<string , Day7Step> allsteps; //master list. All actions performed should involve reference passing.

        public string getDefaultProblem()
        {
            return "Step C must be finished before step A can begin.\r\nStep C must be finished before step F can begin.\r\nStep A must be finished before step B can begin.\r\nStep A must be finished before step D can begin.\r\nStep B must be finished before step E can begin.\r\nStep D must be finished before step E can begin.\r\nStep F must be finished before step E can begin.\r\n";
        }

        public void Parse(string problem)
        {
            
        }

        public string solvePart1()
        {
            return "<li>part 1 solution</li>";
        }

        public string solvePart2()
        {
            return "<li>part 2 solution</li>";
        }
    }

    public class Day7Step
    {
        public Dictionary<string, Day7Step> blocks; //things that this blocks, and that rely on this
        public Dictionary<string, Day7Step> blockedBy; //prereqs before this can continue;
        public string id;

        public Day7Step(string id)
        {
            this.id = id;
            this.blocks = new Dictionary<string, Day7Step>();
            this.blockedBy = new Dictionary<string, Day7Step>();
        }

        public void isBlockedBy(ref Day7Step blocker)
        {
            blocker.blocks.TryAdd(this.id,this);
            this.blockedBy.TryAdd(blocker.id, blocker);
        }
    }
}
