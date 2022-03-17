using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{2,}\b";

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, pattern);

            foreach (Match validName in matches)
            {
                Console.Write($"{validName.Value} ");
            }
        }
    }
}
