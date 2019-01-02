using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AoC18.Models
{
    public class AllDaysModel
    {
        public List<DayModel> allDays { get; set; }
    }

    public class DayModel
    {
        public DayModel(int DayNumber, int numberOfStars, string title)
        {
            this.DayNumber = DayNumber;
            this.firstStarPath = numberOfStars > 0 ? "/images/2b50.png" : "/images/2b50b.png";
            this.secondStarPath = numberOfStars > 1 ? "/images/2b50.png" : "/images/2b50b.png";
            this.title = title;
            this.action = "day" + DayNumber;
        }
        public string action { get; set; }
        public int DayNumber { get; set; }        
        public string firstStarPath { get; set; }
        public string secondStarPath { get; set; }
        public string title { get; set; }
        
    }
}
