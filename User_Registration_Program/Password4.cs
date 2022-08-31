using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    public class Password4
    {
        //pattern for valid rule4
        public static string Condition4REGEX = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
        public bool ValidCondition4(string password4)
        {
            return Regex.IsMatch(password4, Condition4REGEX); ;
        }
    }
}
