using System;
using System.Collections.Generic;

namespace Homework_27
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            List<string> list = new List<string>();
            string rezult = "";

            int years = seconds / 31536000;

            int days = (seconds - (years * 31536000)) / 86400;

            int hours = (seconds - ((years * 31536000) + (days * 86400))) / 3600;

            int minutes = (seconds - ((years * 31536000) + (days * 86400) + (hours * 3600))) / 60;

            int second = (seconds - ((years * 31536000) + (days * 86400) + (hours * 3600) + (minutes * 60)));

            string yearsTemp = years == 1 ? $"{years} year" : $"{years} years";
            string daysTemp = days == 1 ? $"{days} day" : $"{days} days";
            string hoursTemp = hours == 1 ? $"{hours} hour" : $"{hours} hours";
            string minutesTemp = minutes == 1 ? $"{minutes} minute" : $"{minutes} minutes";
            string secondTemp = second == 1 ? $"{second} second" : $"{second} seconds";

            if (years > 0) { list.Add(yearsTemp); }
            if (days > 0) { list.Add(daysTemp); }
            if (hours > 0) { list.Add(hoursTemp); }
            if (minutes > 0) { list.Add(minutesTemp); }
            if (second > 0) { list.Add(secondTemp); }


            switch (list.Count)
            {
                case 0:
                    rezult = $"now";
                    break;

                case 1:
                    rezult = $"{list[0]}";
                    break;

                case 2:
                    rezult = $"{list[0]} and {list[1]}";
                    break;

                case 3:
                    rezult = $"{list[0]}, {list[1]} and {list[2]}";
                    break;

                case 4:
                    rezult = $"{list[0]}, {list[1]}, {list[2]} and {list[3]}";
                    break;

                case 5:
                    rezult = $"{list[0]}, {list[1]}, {list[2]}, {list[3]} and {list[4]}";
                    break;
            }

            return rezult;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HumanTimeFormat.formatDuration(0) + " correct now");
            Console.WriteLine(HumanTimeFormat.formatDuration(1) + " correct 1 second");
            Console.WriteLine(HumanTimeFormat.formatDuration(62) + " correct 1 minute and 2 seconds");
            Console.WriteLine(HumanTimeFormat.formatDuration(15731080) + " correct 182 days, 1 hour, 44 minutes and 40 seconds");
            Console.WriteLine(HumanTimeFormat.formatDuration(253374061) + " correct 8 years, 12 days, 13 hours, 41 minutes and 1 second");
            Console.WriteLine(HumanTimeFormat.formatDuration(120) + " correct 2 minutes");
            Console.WriteLine(HumanTimeFormat.formatDuration(9074506) + " correct 105 days, 41 minutes and 46 seconds");

        }
    }
}

