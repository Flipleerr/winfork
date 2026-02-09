using System;
using System.Collections.Generic;

namespace winfork.Helpers
{
    public class TipOfTheDay
    {
        static List<string> tips = new List<string>();
        static Random random = new Random();

        public static string PickTip()
        {
            foreach (string line in File.ReadLines("tips.txt"))
            {
                tips.Add(line);
            }

            var index = random.Next(tips.Count);
            return tips[index];
        }
    }
}
