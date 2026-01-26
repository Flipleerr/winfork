using System;
using System.Collections.Generic;

namespace winfork.Helpers
{
    public class TipOfTheDay
    {
        List<string> tips = new List<string>();
        Random random = new Random();

        public string PickTip()
        {
            foreach (string line in File.ReadLines("tips.txt"))
            {
                tips.Add(line);
            }

            foreach (string tip in tips)
            {
                var index = random.Next(tip.Length);

                var randomTip = tips[index];
            }
        }
    }
}
