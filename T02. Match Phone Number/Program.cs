using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string validPhoneNumberPattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string phoneNums = Console.ReadLine();
            
            MatchCollection matches = Regex.Matches(phoneNums, validPhoneNumberPattern);

            List<string> result = new List<string>();

            foreach (Match match in matches)
            {
                result.Add(match.ToString());
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
