using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Test_Project
{
    class Program
    {
        static void Main(string[] args) {
            string firstline = "Please type 'age' for age, 'name' for name, 'restart' to restart from here, or 'exit' to exit the program.";
            string line = "\n----------------------";
            Start:
                Console.WriteLine(firstline);
                string input = Console.ReadLine();
                if (input == "age") {
                    goto Age;
                }
                else if (input == "name") {
                    goto Name;
                }
                else if (input == "exit") { 
                    System.Environment.Exit(0);  
                }
                else if (input == "restart") {
                    goto Start;   
                }
            
            Age:
                Console.WriteLine("Please enter your age.");
                string age = Console.ReadLine();
                
                if (age == "restart") {
                goto Start;
                }
                else if (age == "exit") {
                    System.Environment.Exit(0);
                }
                else if (age == "Name")
                {
                    goto Name;
                }
                else if (Regex.IsMatch(age, @"^\d+$")) {
                    Console.WriteLine("\nComputing...\n");
                    //wait
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Completed\n");
                    Console.WriteLine("Your age is " + age + line);
                    goto Age;
                }

                else {
                    Console.WriteLine("\nAge must be a number." + line);
                    goto Age;
                }



            Name:
                Console.WriteLine("Please enter your name.");
                string name = Console.ReadLine();
                if (name == "cancel") {
                    System.Environment.Exit(0);
                }
                else if (name == "restart") {
                    goto Start;
                }
                else if (name == "age") {
                    goto Age;
                }
                else if (Regex.IsMatch(name, @"^\d+$")) {
                    Console.WriteLine("Computing...\n");
                    Console.WriteLine("Completed");
                    Console.WriteLine("\nName must not be special characters." + line);
                    goto Name;
                }
                Console.WriteLine("\nComputing...\n");
                //wait
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Completed\n");
                Console.WriteLine("Your name is " + name + line);
                goto Name;

        }
    }
}
