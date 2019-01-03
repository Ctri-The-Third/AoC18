using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18.DayXCode 
{
    public class Day6 : Day
    {
        Dictionary<int, Day6Coord> coords;
        int[,] grid;
        public Day6()
        {
            this.coords = new Dictionary<int, Day6Coord>();
            
        }

        public string getDefaultProblem()
        {

            //return "1, 1\r\n1, 6\r\n8, 3\r\n3, 4\r\n5, 5\r\n8, 9";
            return "84, 212\r\n168, 116\r\n195, 339\r\n110, 86\r\n303, 244\r\n228, 338\r\n151, 295\r\n115, 49\r\n161, 98\r\n60, 197\r\n40, 55\r\n55, 322\r\n148, 82\r\n86, 349\r\n145, 295\r\n243, 281\r\n91, 343\r\n280, 50\r\n149, 129\r\n174, 119\r\n170, 44\r\n296, 148\r\n152, 160\r\n115, 251\r\n266, 281\r\n269, 285\r\n109, 242\r\n136, 241\r\n236, 249\r\n338, 245\r\n71, 101\r\n254, 327\r\n208, 231\r\n289, 184\r\n282, 158\r\n352, 51\r\n326, 230\r\n88, 240\r\n292, 342\r\n352, 189\r\n231, 141\r\n280, 350\r\n296, 185\r\n226, 252\r\n172, 235\r\n137, 161\r\n207, 90\r\n101, 133\r\n156, 234\r\n241, 185";
        }

        public void Parse(string problem)
        {
            var coordStrings = problem.Split("\r\n");
            int i = 0;
            foreach (string coordString in coordStrings)
            {
                coords.Add(i,new Day6Coord(coordString + ", " + i));
                i++;
            }

            initialiseGrid();
        }
        public void initialiseGrid()
        {
            int minx = 0; //example with padding, based off puzzle input
            int miny = 0;
            int maxy = 10;
            int maxx = 10;

            foreach (Day6Coord coord in coords.Values) //capture larger inputs
            {
                if (coord.x < minx) minx = coord.x;
                if (coord.y < miny) miny = coord.y;
                if (coord.x > maxx) maxx = coord.x;
                if (coord.y > maxy) maxy = coord.y;
            }
            this.grid = new int[maxx - minx, maxy - miny]; //should handle negatives. note, no translation of coords to make then absolute values. watch for negative coordintes in part 2
        }
        public string solvePart1()
        {
            //we're looking for overlapping circles, and then need to determine the granular area of overlapped space (so as to subtract)
            //we can do this with expanding point systems I think? 
            //but the example also works in a 2d array, so the question is what's the correct way of doing this?

            //I think defining an array from the Min-Max coordinates on XY and then running through each coordinate and doing distance checks, recording the ID is the best way to do it.
            //we can then do a series of theroetical checks to search for which hit the inifinite points ( 4 corners and edges at infinite (extreme) distance)
            int operations = 0;
            
            for (int y = 0; y < grid.GetLength(1); y++) //y
            { 
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    int minID = -1;
                    int minDistance = 999999;
                    foreach (Day6Coord coord in coords.Values) 
                    {
                        //distance * distance = (y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1)
                        int distance =  Math.Abs(x - coord.x) + Math.Abs(y - coord.y) ;
                        if (distance == minDistance)
                        {
                            minID = -1;
                        }
                        else if (distance < minDistance)
                        {
                            minDistance = distance;
                            minID = coord.ID;
                        }
                        operations++;

                    }
                    grid[x, y] = minID;
                    
                }
                
                
            }

            for (int y = 0; y < grid.GetLength(1); y++) //y
            {
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    if (grid[x,y] != -1)
                    {
                        coords[grid[x, y]].area++;
                    }

                }
            }

            int maxval = 0;
            int maxid = -1;
            infinityCheck();
            foreach (Day6Coord coord in coords.Values)
            {
                if (!coord.isInfinite)
                {
                    if (coord.area > maxval)
                    {
                        maxval = coord.area;
                        maxid = coord.ID;
                    }

                }
            }
            
            writeGrid();
            return "<li> The area of the largest non-infinite space is "+maxval+", and it is coordinate ID "+ maxid;
        }

        public string solvePart2()
        {
            return "solved part 2";
        }

        public void infinityCheck()
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                if (grid[x,0] != -1)
                {
                    coords[grid[x, 0]].isInfinite = true;
                }
                if (grid[x, grid.GetLength(1)-1] != -1)
                {
                    coords[grid[x, grid.GetLength(1)-1]].isInfinite = true;
                }
            }

            for (int y = 0; y < grid.GetLength(1); y++)
            {
                if (grid[0,y] != -1 )
                {
                    coords[grid[0, y]].isInfinite = true;
                }
                if (grid[grid.GetLength(0)-1, y] != -1)
                {
                    coords[grid[grid.GetLength(0)-1, y]].isInfinite = true;
                }
            }
        }

        public void writeGrid()
        {

            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Day6Output.csv"))
                {
                    string line = "";
                    for (int y = 0; y < grid.GetLength(1); y++)
                    {
                        for (int x = 0; x < grid.GetLength(0); x++)
                        {

                            line += grid[x, y] + ",";
                        }
                        file.WriteLine(line);
                        line = "";

                    }

                    file.Close();
                }
            }
            catch (Exception e)
            { }

        }
    }

    public class Day6Coord
    {
        public Day6Coord (string str)
        {
            var pieces = str.Split(", ");
            x = Int32.Parse(pieces[0]);
            y = Int32.Parse(pieces[1]);
            ID = Int32.Parse(pieces[2]);
        }
        public int x { get; set; }
        public int y { get; set; }
        public int ID { get; set; }
        public bool isInfinite { get; set; }
        public int area { get; set; }

    }


}
