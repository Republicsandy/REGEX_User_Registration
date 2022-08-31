using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_Program
{
    public class Simple_Email
    {
        //pattern for sample email
        public static string SampleEmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public bool SampleEmail(string email)
        {
            return Regex.IsMatch(email, SampleEmailREGEX);
        }
    }
}
