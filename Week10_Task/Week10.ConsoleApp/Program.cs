using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Week10.Extentions;

namespace Week10.ConsoleApp
{
    class Program
    {       
        static void Main(string[] args)
        {
          
            Console.WriteLine("Intro : This task is aimed at evaluating your understanding of leveraging collections and writing to files. ");
            Console.WriteLine();
           
            User users = new User();
            bool continuing= true;
            int xCount = 0;

            #region Create User
            Console.Write("Name: ");
            users.Name = Console.ReadLine();
            Console.Write("Phone-number: ");
            users.PhoneNumber = Console.ReadLine();

            while (continuing)
            {
                Console.Write("EmailAddress: ");
                users.Email = Console.ReadLine();

                if (!StringValidationExtention.ValidateEmail(users.Email))
                {
                    Console.WriteLine("Incorrect amail address. Please enter correct email Address.");
                    xCount++;
                }
                else
                {
                    continuing = false;
                }
            }
            FileExtention.CreateNewDirectory(users.Name, users.PhoneNumber, users.Email);
            #endregion


            #region Dequeue method      
            var x = FileExtention.ReadFileAsync();                                    
            #endregion

            Console.ReadKey();
        }
    }
}