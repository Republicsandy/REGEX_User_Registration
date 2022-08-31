using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    internal class Password
    {
        //pattern for valid rule1
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";
        public bool ValidCondition1(string password)
        {
            return Regex.IsMatch(password, Condition1REGEX); ;
        }
    }
}
