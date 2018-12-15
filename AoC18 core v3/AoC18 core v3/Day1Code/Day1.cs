using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18_core_v3.Day1Code
{
    public class Day1
    {

        private static Dictionary<int, Boolean> frequencies = new Dictionary<int, Boolean>();
        private static int finalFrequency;
        private static int firstMatchingFrequency = -999999;
        public const string defaultproblem = "+14\r\n-15\r\n+7\r\n-10\r\n+14\r\n-6\r\n-13\r\n-8\r\n-1\r\n-19\r\n-16\r\n-5\r\n+1\r\n+11\r\n+7\r\n+16\r\n-3\r\n+1\r\n-10\r\n+8\r\n+17\r\n-10\r\n-12\r\n+1\r\n-16\r\n+5\r\n+12\r\n-20\r\n+9\r\n-19\r\n-10\r\n-2\r\n+10\r\n+6\r\n-10\r\n-17\r\n-2\r\n-4\r\n+14\r\n-4\r\n+11\r\n+4\r\n+19\r\n+5\r\n+4\r\n+15\r\n-3\r\n+8\r\n-17\r\n+4\r\n+10\r\n-9\r\n-16\r\n-7\r\n-16\r\n-7\r\n+11\r\n+15\r\n+14\r\n+21\r\n+14\r\n+11\r\n+17\r\n+19\r\n-12\r\n-14\r\n+10\r\n-1\r\n+6\r\n-12\r\n+16\r\n-18\r\n+3\r\n-8\r\n-5\r\n-5\r\n+13\r\n-2\r\n+8\r\n-16\r\n+5\r\n-14\r\n-9\r\n+4\r\n-11\r\n+6\r\n+11\r\n-9\r\n-16\r\n+20\r\n+19\r\n-8\r\n-21\r\n+17\r\n+19\r\n+19\r\n+13\r\n-7\r\n+9\r\n+17\r\n-11\r\n-2\r\n-12\r\n-15\r\n-5\r\n+16\r\n-13\r\n-13\r\n+19\r\n-5\r\n+6\r\n+23\r\n+10\r\n+8\r\n+8\r\n-18\r\n-4\r\n+19\r\n-16\r\n-10\r\n+16\r\n-2\r\n+18\r\n+7\r\n+5\r\n+13\r\n+3\r\n+5\r\n+12\r\n+18\r\n+4\r\n+9\r\n-19\r\n-18\r\n-15\r\n-18\r\n+14\r\n-5\r\n-4\r\n+10\r\n+17\r\n+13\r\n+11\r\n+9\r\n-10\r\n-7\r\n+11\r\n-10\r\n-12\r\n+13\r\n-10\r\n+18\r\n+16\r\n+11\r\n+12\r\n+1\r\n-14\r\n+15\r\n-18\r\n-10\r\n+19\r\n-1\r\n+20\r\n-9\r\n+5\r\n+1\r\n-2\r\n-18\r\n-9\r\n-10\r\n+16\r\n-4\r\n-11\r\n-15\r\n-10\r\n-5\r\n-10\r\n+6\r\n-18\r\n-8\r\n+12\r\n-9\r\n+12\r\n+3\r\n+21\r\n-3\r\n-9\r\n+7\r\n-13\r\n+1\r\n-18\r\n-8\r\n-1\r\n+4\r\n-14\r\n-11\r\n+13\r\n-21\r\n-20\r\n+5\r\n-3\r\n-9\r\n-3\r\n+9\r\n+17\r\n+11\r\n-2\r\n+8\r\n+11\r\n-2\r\n-7\r\n+21\r\n-13\r\n+16\r\n+18\r\n+10\r\n+19\r\n+6\r\n+9\r\n-3\r\n-18\r\n+15\r\n+18\r\n+20\r\n-15\r\n+3\r\n+17\r\n+10\r\n+15\r\n+11\r\n-16\r\n+2\r\n+5\r\n-3\r\n-5\r\n+12\r\n-10\r\n+12\r\n-20\r\n-9\r\n+7\r\n-20\r\n+16\r\n-1\r\n+10\r\n+2\r\n+16\r\n+19\r\n+19\r\n+4\r\n+3\r\n-8\r\n+3\r\n-17\r\n-12\r\n+10\r\n+15\r\n+11\r\n-19\r\n-3\r\n+14\r\n+10\r\n+13\r\n+8\r\n-13\r\n+7\r\n+1\r\n-4\r\n-7\r\n-11\r\n-19\r\n+6\r\n+11\r\n+11\r\n-19\r\n-11\r\n-7\r\n+16\r\n+4\r\n-3\r\n-3\r\n-2\r\n-10\r\n-8\r\n-8\r\n+6\r\n+6\r\n+1\r\n-9\r\n-10\r\n+11\r\n-8\r\n+18\r\n-13\r\n-14\r\n+21\r\n-2\r\n+4\r\n+8\r\n+14\r\n+22\r\n+7\r\n+3\r\n+6\r\n+16\r\n+2\r\n+13\r\n+8\r\n-1\r\n-6\r\n-19\r\n+10\r\n+7\r\n+5\r\n-20\r\n+18\r\n-16\r\n+8\r\n-4\r\n+5\r\n-15\r\n+9\r\n-13\r\n-20\r\n-15\r\n+16\r\n-12\r\n+2\r\n+19\r\n+11\r\n-6\r\n-7\r\n+19\r\n+5\r\n+18\r\n+12\r\n+14\r\n-16\r\n+3\r\n+18\r\n-10\r\n+12\r\n-1\r\n+16\r\n+15\r\n+19\r\n+8\r\n+14\r\n-18\r\n+16\r\n+6\r\n-14\r\n-7\r\n-14\r\n-5\r\n-14\r\n+15\r\n-14\r\n+12\r\n-8\r\n-19\r\n-5\r\n+7\r\n+5\r\n-1\r\n+20\r\n-13\r\n+5\r\n+21\r\n+19\r\n-17\r\n-10\r\n-20\r\n+10\r\n+3\r\n-12\r\n-2\r\n-6\r\n-8\r\n-16\r\n+7\r\n+12\r\n-5\r\n+15\r\n-19\r\n+11\r\n-17\r\n-6\r\n-4\r\n-11\r\n+16\r\n+18\r\n+6\r\n-15\r\n+1\r\n-13\r\n-5\r\n+6\r\n-2\r\n+8\r\n-17\r\n-14\r\n+12\r\n-14\r\n+17\r\n+1\r\n-11\r\n+8\r\n-20\r\n-10\r\n-7\r\n+19\r\n-18\r\n-10\r\n+13\r\n-10\r\n-18\r\n+5\r\n-12\r\n+30\r\n-1\r\n-2\r\n-22\r\n+31\r\n+26\r\n+39\r\n+18\r\n-11\r\n+15\r\n+10\r\n+6\r\n-1\r\n+8\r\n+9\r\n-7\r\n-8\r\n-20\r\n+5\r\n-37\r\n+40\r\n+46\r\n-2\r\n+11\r\n+5\r\n-11\r\n+44\r\n-10\r\n+4\r\n+39\r\n-13\r\n+40\r\n+11\r\n+18\r\n+16\r\n-12\r\n+9\r\n-14\r\n-14\r\n-16\r\n-6\r\n-3\r\n+34\r\n+12\r\n-29\r\n+21\r\n-17\r\n-6\r\n+64\r\n-1\r\n+28\r\n+24\r\n-14\r\n+1\r\n+19\r\n-18\r\n+9\r\n+18\r\n+2\r\n+1\r\n-14\r\n+22\r\n+19\r\n-7\r\n-18\r\n+12\r\n+12\r\n-5\r\n-5\r\n-9\r\n-23\r\n+10\r\n+23\r\n+15\r\n+14\r\n-11\r\n+21\r\n+14\r\n-22\r\n-18\r\n-7\r\n-4\r\n+25\r\n+34\r\n-151\r\n+25\r\n-29\r\n+19\r\n-96\r\n-31\r\n+218\r\n+150\r\n-31\r\n+18\r\n-63\r\n+126\r\n+71018\r\n+2\r\n-9\r\n+3\r\n-5\r\n-16\r\n-6\r\n-17\r\n-4\r\n-13\r\n-1\r\n+3\r\n-4\r\n-19\r\n-1\r\n+6\r\n+2\r\n+10\r\n+11\r\n+16\r\n+5\r\n+22\r\n+10\r\n+16\r\n+4\r\n+4\r\n+4\r\n-14\r\n+7\r\n-6\r\n-12\r\n+1\r\n+9\r\n+17\r\n-7\r\n-6\r\n+16\r\n-7\r\n+11\r\n-15\r\n+12\r\n+10\r\n+5\r\n+19\r\n-8\r\n-14\r\n+9\r\n+16\r\n-13\r\n-11\r\n+14\r\n-16\r\n-16\r\n-2\r\n+9\r\n-11\r\n+14\r\n+2\r\n+9\r\n+15\r\n+8\r\n+2\r\n-12\r\n+3\r\n+17\r\n-4\r\n-7\r\n+6\r\n-16\r\n+12\r\n+7\r\n-14\r\n-16\r\n+8\r\n-21\r\n+4\r\n+12\r\n-2\r\n-21\r\n-20\r\n+1\r\n+7\r\n+37\r\n+1\r\n+7\r\n+24\r\n+13\r\n-15\r\n+6\r\n+10\r\n-11\r\n+18\r\n+1\r\n-12\r\n+2\r\n+12\r\n+4\r\n+3\r\n+7\r\n-15\r\n+12\r\n+8\r\n+12\r\n+5\r\n+11\r\n-5\r\n+9\r\n+16\r\n+14\r\n+19\r\n-14\r\n+4\r\n+12\r\n+14\r\n+12\r\n+19\r\n+13\r\n+4\r\n-12\r\n-19\r\n+5\r\n+10\r\n+15\r\n-9\r\n-14\r\n+4\r\n-8\r\n-5\r\n-5\r\n+15\r\n+4\r\n-15\r\n-12\r\n+6\r\n-7\r\n-4\r\n-2\r\n-19\r\n-7\r\n-11\r\n-3\r\n+2\r\n+2\r\n-14\r\n-1\r\n+12\r\n+10\r\n-2\r\n+8\r\n-11\r\n+24\r\n-7\r\n+5\r\n+10\r\n+1\r\n+15\r\n+12\r\n-16\r\n-18\r\n+2\r\n+1\r\n-17\r\n+4\r\n+11\r\n+3\r\n+8\r\n-7\r\n-11\r\n-2\r\n-17\r\n+13\r\n-12\r\n-15\r\n-16\r\n-16\r\n+6\r\n+11\r\n+10\r\n-13\r\n-19\r\n-6\r\n+16\r\n-15\r\n-5\r\n-9\r\n+10\r\n-12\r\n-14\r\n+18\r\n-19\r\n-8\r\n-19\r\n-6\r\n-17\r\n-18\r\n+13\r\n+41\r\n-4\r\n+8\r\n-6\r\n+20\r\n+18\r\n-12\r\n-5\r\n-12\r\n-2\r\n-4\r\n-6\r\n-7\r\n+5\r\n+35\r\n+20\r\n+10\r\n-11\r\n+4\r\n+2\r\n-7\r\n+16\r\n-10\r\n-20\r\n+3\r\n-9\r\n-10\r\n+22\r\n+26\r\n+16\r\n+13\r\n-7\r\n-9\r\n-14\r\n+10\r\n-5\r\n+11\r\n-3\r\n-10\r\n-17\r\n+8\r\n+10\r\n+8\r\n+13\r\n-10\r\n+7\r\n+7\r\n-1\r\n+28\r\n+16\r\n+10\r\n+17\r\n-16\r\n+11\r\n+17\r\n+4\r\n+15\r\n+2\r\n+9\r\n+8\r\n-10\r\n-2\r\n+3\r\n+15\r\n+17\r\n-16\r\n+11\r\n-4\r\n+11\r\n-4\r\n+11\r\n+4\r\n-3\r\n+9\r\n-2\r\n-18\r\n-17\r\n+6\r\n-12\r\n+11\r\n+9\r\n-10\r\n-8\r\n+12\r\n-15\r\n-1\r\n+18\r\n+16\r\n-19\r\n+15\r\n+7\r\n+20\r\n-3\r\n+18\r\n-11\r\n+7\r\n-17\r\n-13\r\n-15\r\n+9\r\n+14\r\n+12\r\n-18\r\n-20\r\n-22\r\n+7\r\n-6\r\n-3\r\n+15\r\n+8\r\n+22\r\n+19\r\n+17\r\n+7\r\n+3\r\n+2\r\n-14\r\n-9\r\n-1\r\n+4\r\n+13\r\n-15\r\n+3\r\n+15\r\n+7\r\n-1\r\n+11\r\n+9\r\n-14\r\n-16\r\n+2\r\n+23\r\n+14\r\n+1\r\n+20\r\n+14\r\n-4\r\n+19\r\n-18\r\n+14\r\n+2\r\n+17\r\n-12\r\n-1\r\n-19\r\n-13\r\n-17\r\n-6\r\n-10\r\n-14\r\n-7\r\n-10\r\n+18\r\n+10\r\n+15\r\n-1\r\n-3\r\n+14\r\n+3\r\n-18\r\n-9\r\n+3\r\n-12\r\n-6\r\n+5\r\n+5\r\n+9\r\n+15\r\n+14\r\n-12\r\n-4\r\n+9\r\n+16\r\n-13\r\n-9\r\n-15\r\n+17\r\n+18\r\n+1\r\n+16\r\n-3\r\n+19\r\n+17\r\n+18\r\n+7\r\n+6\r\n-14\r\n-2\r\n-6\r\n+3\r\n+2\r\n+15\r\n-19\r\n-5\r\n-9\r\n-12\r\n-16\r\n+20\r\n+7\r\n-21\r\n+13\r\n+6\r\n-8\r\n+9\r\n+17\r\n-19\r\n-13\r\n+19\r\n+9\r\n+15\r\n-16\r\n-7\r\n-10\r\n-20\r\n-15\r\n-14\r\n-19\r\n-13\r\n-23\r\n-1\r\n-8\r\n-8\r\n+10\r\n+5\r\n-22\r\n+8\r\n-11\r\n-20\r\n+17\r\n-1\r\n-2\r\n+5\r\n-21\r\n+11\r\n+17\r\n+3\r\n-7\r\n-7\r\n-19\r\n+15\r\n-38\r\n+1\r\n-18\r\n-17\r\n-23\r\n-21\r\n-71664";
        /*For example, if the device displays frequency changes of +1, -2, +3, +1, then starting from a frequency of zero, the following changes would occur:

       Current frequency  0, change of +1; resulting frequency  1.
       Current frequency  1, change of -2; resulting frequency -1.
       Current frequency -1, change of +3; resulting frequency  2.
       Current frequency  2, change of +1; resulting frequency  3.
       In this example, the resulting frequency is 3.*/
        public static int GetFinalFrequency()
        {
            return finalFrequency;
        }
        public static int GetFirstMatcihngFrequency()
        {
            return firstMatchingFrequency;
        }

        public static Boolean LogFrequency(int i)
        {
            //returns true if frequency already recorded
            var found = frequencies.ContainsKey(i);
            if (!found) { frequencies.Add(i, true); }
            else if (found)
                if (firstMatchingFrequency.Equals(null) || firstMatchingFrequency == -999999)
                {
                    firstMatchingFrequency = i;
                }
            return found;
        }

        public static void parse(String text)
        {
            var frequency = 0;
            //asume each line is broken up by a \n
            var instructions = text.Split("\r\n");
            int counter = 0;
            while (firstMatchingFrequency == -999999 && counter < 5000)
            {
                foreach (var instruction in instructions)
                {
                    //is it positive or negative?
                    String direction = instruction.Substring(0, 1);
                    var frequencyMod = 0;
                    try
                    {
                        frequencyMod = int.Parse(instruction.Substring(1));
                    }
                    catch (Exception e)
                    {
                        frequencyMod = 0;
                    }
                    if (direction == "+")
                    {
                        frequency += frequencyMod;
                    }
                    else if (direction == "-")
                    {
                        frequency -= frequencyMod;
                    }
                    LogFrequency(frequency);
                }
                counter += 1;
                if (counter == 1)
                {
                    finalFrequency = frequency;
                }
            }
        }

    }
}
