using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    class Reg_Ex
    {
        //pattern for valid name
        public static string REGEX = (@"^[A-Z][a-zA-Z]{2,}$");
        public bool ValidFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX);
        }
    }
}
