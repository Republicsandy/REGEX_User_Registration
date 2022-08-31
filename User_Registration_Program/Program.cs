using System;

namespace User_Registration_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Reg Expressions!");
            Console.WriteLine("press 1 for first name");
            Console.WriteLine("press 2 for last name");
            Console.WriteLine("press 3 for email");
            Console.WriteLine("press 4 for mobil number");
            Console.WriteLine("press 5 for password1");
            Console.WriteLine("press 6 for password2");
            Console.WriteLine("press 7 for password3");
            Console.WriteLine("press 8 for password4");
            var getValueByUser = Convert.ToInt32(Console.ReadLine());
            switch (getValueByUser)
            {
                case 1:
                    Console.WriteLine("Enter First Name :");
                    string name = Console.ReadLine();
                    Reg_Ex regex = new Reg_Ex();
                    if (regex.ValidFirstName(name))
                        Console.WriteLine("First Name is VALID !!");
                    else
                        Console.WriteLine("First Name is INVALID !!");
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name :");
                    string lastName = Console.ReadLine();
                    Last_Name_Rgex regexlastname = new Last_Name_Rgex();
                    if (regexlastname.ValidLastName(lastName))
                        Console.WriteLine("Last Name is VALID !!");
                    else
                        Console.WriteLine("Last Name is INVALID !!");
                    break;

                case 3:
                    Console.WriteLine("Enter Email :");
                    string email = Console.ReadLine();
                    Regex_Email regexemail = new Regex_Email();
                    if (regexemail.ValidEmail(email))
                        Console.WriteLine("Email is VALID !!");
                    else
                        Console.WriteLine("Email is INVALID !!");
                    break ;
                case 4:
                    Console.WriteLine("Enter Mobile Number :");
                    string mobilenum = Console.ReadLine();
                    Regex_Mobil_Number regexnumber = new Regex_Mobil_Number();
                    if (regexnumber.ValidMobile(mobilenum))
                        Console.WriteLine("Mobile Number is VALID !!");
                    else
                        Console.WriteLine("Mobile Number is INVALID !!");
                    break;

                case 5:
                    Console.WriteLine("Enter Password :");
                    string Rule1 = Console.ReadLine();
                    Password password = new Password();
                    if (password.ValidCondition1(Rule1))
                        Console.WriteLine("Password is VALID !!");
                    else
                        Console.WriteLine("Password is INVALID !!");
                    break;
                case 6:
                    Console.WriteLine("Enter Password :");
                    string Rule2 = Console.ReadLine();
                    Password2 password2 = new Password2();
                    if (password2.ValidCondition2(Rule2))
                        Console.WriteLine("Password is VALID !!");
                    else
                        Console.WriteLine("Password is INVALID !!");
                    break;
                case 7:
                    Console.WriteLine("Enter Password :");
                    string Rule3 = Console.ReadLine();
                    Password3 password3 = new Password3();
                    if (password3.ValidCondition3(Rule3))
                        Console.WriteLine("Password is VALID !!");
                    else
                        Console.WriteLine("Password is INVALID !!");
                    break;
                case 8:
                    Console.WriteLine("Enter Password :");
                    string Rule4 = Console.ReadLine();
                    Password4 password4 = new Password4();
                    if (password4.ValidCondition4(Rule4))
                        Console.WriteLine("Password is VALID !!");
                    else
                        Console.WriteLine("Password is INVALID !!");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    return;
            }
        }
    }
}
