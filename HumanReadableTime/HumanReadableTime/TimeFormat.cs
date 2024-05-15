using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanReadableTime
{
    public static class TimeFormat{
        
        private static string convertToHour(int seconds)
        {
            double hour = (double)seconds / 3600;


            return "";

        }
        public static string GetReadableTime(int seconds){



            int hour = seconds / 3600;
            int hourMinLeft = seconds % 3600;
            
            int minutes = hourMinLeft / 60;
            seconds = hourMinLeft % 60;

            return (hour > 9 ? hour.ToString() : hour==0 ? "00" : "0"+hour) + ":" + (minutes > 9 ? minutes.ToString() : minutes == 0 ? "00" : "0"+minutes) + ":" + (seconds > 9 ? seconds.ToString() : seconds == 0 ? "00" : "0"+seconds);
            
        }
    }
}
