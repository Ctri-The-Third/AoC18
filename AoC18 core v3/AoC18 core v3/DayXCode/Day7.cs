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
            return "Step F must be finished before step P can begin.\r\nStep R must be finished before step J can begin.\r\nStep X must be finished before step H can begin.\r\nStep L must be finished before step N can begin.\r\nStep U must be finished before step Z can begin.\r\nStep B must be finished before step C can begin.\r\nStep S must be finished before step C can begin.\r\nStep N must be finished before step Y can begin.\r\nStep I must be finished before step J can begin.\r\nStep H must be finished before step K can begin.\r\nStep G must be finished before step Z can begin.\r\nStep Q must be finished before step V can begin.\r\nStep E must be finished before step P can begin.\r\nStep P must be finished before step W can begin.\r\nStep J must be finished before step D can begin.\r\nStep V must be finished before step W can begin.\r\nStep T must be finished before step D can begin.\r\nStep Z must be finished before step A can begin.\r\nStep K must be finished before step A can begin.\r\nStep Y must be finished before step O can begin.\r\nStep O must be finished before step W can begin.\r\nStep C must be finished before step M can begin.\r\nStep D must be finished before step A can begin.\r\nStep W must be finished before step M can begin.\r\nStep M must be finished before step A can begin.\r\nStep C must be finished before step A can begin.\r\nStep F must be finished before step Z can begin.\r\nStep I must be finished before step A can begin.\r\nStep W must be finished before step A can begin.\r\nStep T must be finished before step C can begin.\r\nStep S must be finished before step K can begin.\r\nStep B must be finished before step J can begin.\r\nStep O must be finished before step A can begin.\r\nStep Q must be finished before step P can begin.\r\nStep G must be finished before step M can begin.\r\nStep R must be finished before step T can begin.\r\nStep B must be finished before step G can begin.\r\nStep J must be finished before step O can begin.\r\nStep X must be finished before step E can begin.\r\nStep X must be finished before step C can begin.\r\nStep H must be finished before step Y can begin.\r\nStep Y must be finished before step A can begin.\r\nStep X must be finished before step W can begin.\r\nStep H must be finished before step A can begin.\r\nStep X must be finished before step A can begin.\r\nStep I must be finished before step M can begin.\r\nStep G must be finished before step J can begin.\r\nStep N must be finished before step G can begin.\r\nStep D must be finished before step M can begin.\r\nStep L must be finished before step D can begin.\r\nStep V must be finished before step T can begin.\r\nStep I must be finished before step Y can begin.\r\nStep S must be finished before step J can begin.\r\nStep K must be finished before step Y can begin.\r\nStep F must be finished before step R can begin.\r\nStep U must be finished before step T can begin.\r\nStep Z must be finished before step M can begin.\r\nStep T must be finished before step Z can begin.\r\nStep B must be finished before step I can begin.\r\nStep E must be finished before step K can begin.\r\nStep N must be finished before step J can begin.\r\nStep X must be finished before step Q can begin.\r\nStep F must be finished before step Y can begin.\r\nStep H must be finished before step P can begin.\r\nStep Z must be finished before step D can begin.\r\nStep V must be finished before step O can begin.\r\nStep E must be finished before step C can begin.\r\nStep V must be finished before step C can begin.\r\nStep P must be finished before step A can begin.\r\nStep B must be finished before step N can begin.\r\nStep S must be finished before step W can begin.\r\nStep P must be finished before step D can begin.\r\nStep L must be finished before step W can begin.\r\nStep D must be finished before step W can begin.\r\nStep K must be finished before step C can begin.\r\nStep L must be finished before step M can begin.\r\nStep R must be finished before step O can begin.\r\nStep F must be finished before step L can begin.\r\nStep R must be finished before step H can begin.\r\nStep K must be finished before step O can begin.\r\nStep T must be finished before step W can begin.\r\nStep R must be finished before step K can begin.\r\nStep C must be finished before step W can begin.\r\nStep N must be finished before step T can begin.\r\nStep R must be finished before step P can begin.\r\nStep E must be finished before step M can begin.\r\nStep G must be finished before step T can begin.\r\nStep U must be finished before step K can begin.\r\nStep Q must be finished before step D can begin.\r\nStep U must be finished before step S can begin.\r\nStep J must be finished before step V can begin.\r\nStep P must be finished before step Y can begin.\r\nStep X must be finished before step Z can begin.\r\nStep U must be finished before step H can begin.\r\nStep H must be finished before step M can begin.\r\nStep I must be finished before step C can begin.\r\nStep V must be finished before step M can begin.\r\nStep N must be finished before step I can begin.\r\nStep B must be finished before step K can begin.\r\nStep R must be finished before step Q can begin.\r\nStep O must be finished before step C can begin.";
            //return "Step C must be finished before step A can begin.\r\nStep C must be finished before step F can begin.\r\nStep A must be finished before step B can begin.\r\nStep A must be finished before step D can begin.\r\nStep B must be finished before step E can begin.\r\nStep D must be finished before step E can begin.\r\nStep F must be finished before step E can begin.\r\n";
        }

        public void Parse(string problem)
        {
            allsteps = new Dictionary<string, Day7Step>();
            var strings = problem.Split("\r\n");
            foreach (string str in strings)
            {
                if (str.Length >=36)
                { 
                    var blockerID = str.Substring(5, 1);
                    var id = str.Substring(36, 1);
                    var step = new Day7Step(id);
                    var blocker = new Day7Step(blockerID);

                    allsteps.TryAdd(id, step);
                    allsteps.TryAdd(blockerID, blocker);

                    step = allsteps[id]; //getA
                    blocker = allsteps[blockerID]; //getB

                    step.isBlockedBy(ref blocker);  //update both

                    allsteps[id] = step; //setA
                    allsteps[blockerID] = blocker; //setB



                }
            }
        }

        public string solvePart1()
        {

            //search through all steps
            //for each step, check all "is blocked by"s
            //if all "is blocked by" is in list of completed, this step is added to list of completed.
            //if length of solution is equal to count of steps, complete.

            List<Day7Step> answers = new List<Day7Step>();
            foreach (var step in allsteps.Values)
            {
                //find the sourceIDs - those that are not blocked. then arrange then alphabetically, then process them.    
                if (step.blockedBy.Values.Count == 0)
                {
                    completeAStep(answers, step);
                }

            }
            string output = "";
            foreach (var answer in answers)
            {
                output += answer.id;
            }
            return "<li>The assembly order for the parts is: ["+output+"]</li>";
        }

        public List<Day7Step> completeAStep(List<Day7Step> answers, Day7Step step)
        {
            //this is a step we are trying to solve. 
            // step 1, check all "is blocked by". 
            // if answers contains every "blocker", add this to answers - it is now solved.
            // then, foreach 'blocks', try and solve

            //currently we're getting repeated things. Worth maintaing a global answers string just for debugging?
            var blocked = false;
            foreach (var blocker in step.blockedBy.Values)
            {
                if (!answers.Contains(blocker))
                {
                    blocked = true;
                }
            }
            if (!blocked)
            {
                answers.Add(step);
                foreach( var possiblyUnblocked in step.blocks.Values)
                {
                    completeAStep(answers, possiblyUnblocked);
                }
            }


            return answers;
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
