using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    class Last_Name_Rgex
    {
        public static string lastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidLastName(string lastName)
        {
            return Regex.IsMatch(lastName, lastNameREGEX);
        }
    }
}
