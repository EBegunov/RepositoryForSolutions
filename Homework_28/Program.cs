using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_27
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) return "now";
            var count = 0;

            return new Dictionary<int, string>
            {
                { 365 * 24 * 60 * 60, "year" },
                { 24 * 60 * 60, "day"},
                { 60 * 60, "hour"},
                { 60, "minute"},
                { 1, "second"}
            }
            .Where(m => seconds / m.Key > 0)
            .Select(m =>
            {
                int number = seconds / m.Key;
                seconds %= m.Key;
                count++;
                return $"{number} {m.Value}{(number > 1 ? "s" : "")}";
            })
            .ToList()
            .Select((part, i) => (i == 0 ? "" : i == count - 1 ? " and " : ", ") + part)
            .Aggregate((a, b) => a + b);
        }


        public static string formatDuration2(int seconds)
        {
            var t = TimeSpan.FromSeconds(seconds);
            Func<int, string, string> f = (n, l) => n == 0 ? "" : $"{n} {l}" + (n == 1 ? "" : "s");
            var h = new[] { f(t.Days / 365, "year"), f(t.Days % 365, "day"), f(t.Hours, "hour"), f(t.Minutes, "minute"), f(t.Seconds, "second") }.Where(p => p.Any());
            return h.Count() == 0 ? "now" : h.Count() == 1 ? h.Single() : string.Join(", ", h.Take(h.Count() - 1)) + " and " + h.Last();
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

