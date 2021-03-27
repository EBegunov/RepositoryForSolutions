using System;

/* 
Enjoying your holiday, you head out on a scuba diving trip!

Disaster!! The boat has caught fire!!

You will be provided a string that lists many boat related items. If any of these items are "Fire" you must spring into action. Change any instance of "Fire" into "~~". Then return the string.

Go to work!

*/

namespace Homework_24
{
    public class Kata
    {
        public static string FireFight(string s)
        {
            return s.Replace("Fire", "~~");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            string a = "Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain";
            Console.WriteLine(Kata.FireFight(a));
            
        }
    }
}
