using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Program
    {
        static int GetAge()
        {
            while (true)
            {
                Console.Write("Please enter your age: ");
                string ageInput = Console.ReadLine();

                try
                {
                    int age = int.Parse(ageInput);
                    if (age < 0)
                    {
                        throw new ArgumentException("Age cannot be negative.");
                    }
                    return age;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid age (a whole number).");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Invalid input. {e.Message}");
                }
                
            }
        }

        static string DetermineAgeCategory(int age)
        {
            if (age < 18)
            {
                return "minor";
            }
            else if (age >= 18 && age <= 65)
            {
                return "adult";
            }
            else
            {
                return "senior";
            }
        }

        static void Main(string[] args)
        {
            char choice;
            do
            {
                int age = GetAge();
                string ageCategory = DetermineAgeCategory(age);
                Console.WriteLine($"You are a {ageCategory}.");

                Console.WriteLine("Do you want to Continue? (Y/N): ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (choice == 'Y' || choice == 'y');
           
        }
        
    }
}

