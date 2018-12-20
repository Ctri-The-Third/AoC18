using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18_core_v3.DayXCode
{
    public class Day4
    {
        public static string DefaultProblem = "[1518-11-01 00:00] Guard #10 begins shift\r\n[1518-11-01 00:05] falls asleep\r\n[1518-11-01 00:25] wakes up\r\n[1518-11-01 00:30] falls asleep\r\n[1518-11-01 00:55] wakes up\r\n[1518-11-01 23:58] Guard #99 begins shift\r\n[1518-11-02 00:40] falls asleep\r\n[1518-11-02 00:50] wakes up\r\n[1518-11-03 00:05] Guard #10 begins shift\r\n[1518-11-03 00:24] falls asleep\r\n[1518-11-03 00:29] wakes up\r\n[1518-11-04 00:02] Guard #99 begins shift\r\n[1518-11-04 00:36] falls asleep\r\n[1518-11-04 00:46] wakes up\r\n[1518-11-05 00:03] Guard #99 begins shift\r\n[1518-11-05 00:45] falls asleep\r\n[1518-11-05 00:55] wakes up";

        public static string parse(string problem)
        {


            /* //
                [1518-11-01 00:00] Guard #10 begins shift
                [1518-11-01 00:05] falls asleep
                [1518-11-01 00:25] wakes up
                [1518-11-01 00:30] falls asleep
                [1518-11-01 00:55] wakes up
                [1518-11-01 23:58] Guard #99 begins shift
                [1518-11-02 00:40] falls asleep
                [1518-11-02 00:50] wakes up
                [1518-11-03 00:05] Guard #10 begins shift
                [1518-11-03 00:24] falls asleep
                [1518-11-03 00:29] wakes up
                [1518-11-04 00:02] Guard #99 begins shift
                [1518-11-04 00:36] falls asleep
                [1518-11-04 00:46] wakes up
                [1518-11-05 00:03] Guard #99 begins shift
                [1518-11-05 00:45] falls asleep
                [1518-11-05 00:55] wakes up
                */

            List<Day4Entry> entries = new List<Day4Entry>();
            var problems = problem.Split("\r\n");
            foreach (string unparsedEntry in problems)
            {
                Day4Entry entry = new Day4Entry(unparsedEntry);
                entries.Add(entry);
            }

            entries.Sort();
            string returnvalue = "";
            foreach (var entry in entries)
            {
                returnvalue += entry.ToString() + "<br/>";
            }

            //now that we're sorted, we can do several things
            //loop through the entries and get days
            //simultaneously get a list of guards
            var guards = new Dictionary<int, Day4Guard>();
            var days = new Dictionary<DateTime, Day4day>();
            int guardID;
            Day4day currentDay;
            foreach (var entry in entries)
            {
                //[1518-11-01 23:58] Guard #99 begins shift
                //[1518 - 11 - 02 00:40] falls asleep
                //[1518 - 11 - 02 00:50] wakes up
                if (entry.action.Substring(0, 5) == "Guard")
                { //new shift, create day

                }
                else if (entry.action.Substring(0, 5) == "falls")
                {

                }
                else if (entry.action.Substring(0, 5) == "wakes")
                {

                }
            }



            return returnvalue;
        }
    }
    public class Day4Entry : IComparable<Day4Entry>
    {
        public DateTime timestamp;

        public string action;
        public Day4Entry(string str)
        {
            try
            {
                var timestampfragment = str.Split("] ")[0].Substring(1);
                timestamp = DateTime.Parse(timestampfragment);
                action = str.Split("] ")[1];

            }
            catch (Exception e)
            {
                Console.WriteLine("[ERROR][Day4] - Failed to parse:" + str);
            }
        }

        int IComparable<Day4Entry>.CompareTo(Day4Entry other)
        {
            if (other == null) return 1;
            if (this.timestamp == other.timestamp)
            {
                return 0;
            }
            else if (this.timestamp < other.timestamp)
            {
                return -1;
            }
            else if (this.timestamp > other.timestamp)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return "[" + this.timestamp.ToString() + "] " + this.action;

        }
        //date & time
        //ID as text
        //action = start/sleep/wake
    }

    public class Day4Guard
    {
        //ID
        //total minutes asleep
    }

    public class Day4day
    {
        public DateTime timestamp;
        public bool[] minutes = new bool[60];
        public Day4Guard guard;
        public Day4day (DateTime timestamp, ref Day4Guard guard)
        {
            this.timestamp = timestamp;
            this.guard = guard;
        }

        public void fallAsleep(int minute)
        { }
        public void awaken(int minute)
        { }
        //1 date = key
        //60 booleans
        //1 guard assigned

    }
}
