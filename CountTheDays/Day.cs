using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheDays
{
    public class Day{
        public string countDays(DateTime d)
        {
            if(d.ToLongDateString().Equals(DateTime.Now.ToLongDateString())){
                return "Today is the day!";
            }
            else if(d < DateTime.Now){
                return "The day is in the past!";
            }
            else{
                return (d - DateTime.Now).Days + " days";
            }
        }
    }
}
