using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GoldSmith.Helper
{
    public static class Helper
    {
        public static bool IsEmail(string email)
        {
            const string MatchEmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
    + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
    + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
    + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";

            bool isEmail = Regex.IsMatch(email, MatchEmailPattern, RegexOptions.IgnoreCase);

            return isEmail;
        }
    }

    //v1.3
    public class Ogretmen
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    //
}
