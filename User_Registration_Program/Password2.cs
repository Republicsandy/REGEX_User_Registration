using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    public class Password2
    {
        //pattern for valid rule2
        public static string Condition2REGEX = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
        public bool ValidCondition2(string password2)
        {
            return Regex.IsMatch(password2, Condition2REGEX); ;
        }
    }
}
