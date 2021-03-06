using System;
using System.Text.RegularExpressions;

namespace Algoritms.Warmup {
    public class TimeConversion
    {
        public static string Run(string s)
        {
            Regex r = new Regex(@"(PM)", RegexOptions.IgnoreCase);

            Match isPM = r.Match(s);
            var sArr = s.Split(new char[]{':', 'A','P'});

            var hour = sArr[0];
            var minute = sArr[1];
            var second = sArr[2];
            
            if (isPM.Success && !hour.Equals("12")) 
            {
                var intHour = Int32.Parse(hour) + 12;
                hour = intHour.ToString();
            }

            if (!isPM.Success && hour.Equals("12"))
            {
                hour = "00";
            }

            return $"{hour}:{minute}:{second}";
            
        }
    }
}