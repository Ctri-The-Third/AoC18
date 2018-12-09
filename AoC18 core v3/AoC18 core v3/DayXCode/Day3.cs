using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AoC18_core_v3.DayXCode;

namespace AoC18_core_v3.DayXCode
{
    
    public class Day3
    {
        public const string defaultproblem = "";
        int x;
        int y;
        int w;
        int h;
        int ID;

        Day3Coord topleft;
        Day3Coord botright;

        public Day3(int x, int y, int w, int h, int ID)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.ID = ID;

            this.topleft = new Day3Coord(x + 1, y + 1);
            this.botright = new Day3Coord(x + 1 + w, y + 1 + h);

        }

        public Day3(string input)
        {
            //#2 @ 309,394: 15x21
            //#1357 @ 275,416: 16x21

            string[] components = input.Split(" @ ");
            this.ID = int.Parse(components[0]);
            string[] components2 = components[1].Split(": ");
            string[] coordinates = components2[0].Split(",");
            string[] dimensions = components2[1].Split("x");
            //int x, int y, int w, int h, int ID
            new Day3(int.Parse(coordinates[0]), int.Parse(coordinates[1]), int.Parse(dimensions[0]), int.Parse(dimensions[1]), this.ID);
        }
        /*Each Elf has made a claim about which area of fabric would be ideal for Santa's suit. All claims have an ID and consist of a single rectangle with edges parallel to the edges of the fabric. Each claim's rectangle is defined as follows:

        The number of inches between the left edge of the fabric and the left edge of the rectangle.
        The number of inches between the top edge of the fabric and the top edge of the rectangle.
        The width of the rectangle in inches.
        The height of the rectangle in inches.
        
        #1 @ 1,3: 4x4
        #2 @ 3,1: 4x4
        #3 @ 5,5: 2x2
        Visually, these claim the following areas:

        ........
        ...2222.
        ...2222.
        .11XX22.
        .11XX22.
        .111133.
        .111133.
        ........ */





    }

class Day3Coord
{
    public int x;
    public int y;

    public Day3Coord(int x, int y)
    {
        this.x = x;
        this.y = y;

    }
}
}