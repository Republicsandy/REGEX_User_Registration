using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    internal class Password3
    {
        //pattern for valid rule3
        public static string Condition3REGEX = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9@$!%*#?&]{8,}$";
        public bool ValidCondition3(string password3)
        {
            return Regex.IsMatch(password3, Condition3REGEX); ;
        }
    }
}
