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
            }
           
        }
    }
}
