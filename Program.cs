using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>
            {"Doom","Call of Duty","Duke Nukem","NBALive" };

            IEnumerable<string> longVideoGameNames =
                videoGameNames.OrderBy(name => name.Length);

            foreach (var i in videoGameNames)
            {
                Console.WriteLine(i);
            }
        }
    }
}
