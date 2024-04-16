using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Naqi
            Random generator = new Random();
            List <int> numbers = new List<int>();


            Console.WriteLine("Here is the list of numbers:");

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10,21));
                Console.Write(numbers[i]+", ");
            }

            int user = 0; ;
            while (user != 8)
            {
                Console.WriteLine();
                Console.WriteLine("Select one of the options:");
                Console.WriteLine("1. Sort List");
                Console.WriteLine("2. Make New List of Random Numbers");
                Console.WriteLine("3. Remove a Number");
                Console.WriteLine("4. Add Value to List");
                Console.WriteLine("5. Count # of Occurence of Value");
                Console.WriteLine("6. Print Largest Value");
                Console.WriteLine("7. Print Smallest Value");
                Console.WriteLine("8. Quit");

                user = Convert.ToInt32(Console.ReadLine());

                if (user == 1)
                {
                    numbers.Sort();
                }
                else if (user == 2)
                {
                    List<int> numbersNew = new List<int>();

                    for (int j = 0; j < 25; j++)
                    {
                        numbers.Add(generator.Next(10, 21));
                        Console.Write(numbers[j] + ", ");
                    }
                }
                else if (user == 3)
                {
                    Console.WriteLine("Enter a number to remove:");
                    numbers.Remove(Convert.ToInt32(Console.ReadLine()));
                }
                else if (user == 4)
                {
                    Console.WriteLine("What value would you like to add?");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }
                else if (user == 5)
                {
                    int counter = 0;

                    Console.WriteLine("What number do you want to look for?");
                    int input = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j < 25; j++)
                    {
                        if (numbers[j] == input)
                        {
                            counter = counter + 1;
                        }
                    }

                    Console.WriteLine($"There are {counter} places with the number {input}");
                    
                }
                else if (user == 6)
                {
                    numbers.Sort();
                    Console.WriteLine($"The largest value in the list is {numbers.Count - 1}.");
                }
                else if (user == 7)
                {
                    numbers.Sort();
                    Console.WriteLine($"The smallest value in the list is {numbers[0]}");
                }
            }
        }
    }
}