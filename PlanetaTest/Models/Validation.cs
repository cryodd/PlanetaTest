using System;
using System.Text.RegularExpressions;

namespace PlanetaTest.Models
{
    public class Validation
    {
        public static bool IpStringValidadtion(string IpString)
        {
            Regex regex = new Regex(@" ^ (( \d | [1-9]\d | 1\d\d | 2[0-5][0-5]) \.){3} ( \d | [1-9]\d | 1\d\d | 2[0-5][0-5]) (\/ | \%2F) (\d|[1-2][\d]|3[0-2]) $",RegexOptions.IgnorePatternWhitespace);
            return regex.IsMatch(IpString);
        }
    }
}