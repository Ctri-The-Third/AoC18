using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18.wwwroot.Day1Code
{
    public class Day1
{
     /*For example, if the device displays frequency changes of +1, -2, +3, +1, then starting from a frequency of zero, the following changes would occur:

    Current frequency  0, change of +1; resulting frequency  1.
    Current frequency  1, change of -2; resulting frequency -1.
    Current frequency -1, change of +3; resulting frequency  2.
    Current frequency  2, change of +1; resulting frequency  3.
    In this example, the resulting frequency is 3.*/
    public static int parse (String text)
    {
        var frequency = 0;
        //asume each line is broken up by a \n
        var instructions = text.Split("\n");
        foreach (var instruction in instructions)
        {
            //is it positive or negative?
            var direction = direction.Substring(1);
            var frequencyMod = int.Parse(direction.substring(direction.length - 1));
            if (direction == "+")
            {
                frequency += frequencyMod;
            }
            else if (direciont == "-")
            {
                frequency -= frequencyMod;
            }
            return frequency;
        }

    }

}
}
