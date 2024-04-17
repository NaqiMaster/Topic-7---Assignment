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
            Console.WriteLine();

            for (int i = 0; i < 25; i++)
            {
                numbers.Add(generator.Next(10, 21));
            }

            int user = 0; ;
            while (user != 9)
            {
                Console.Clear();

               for (int i = 0; i < numbers.Count; i++)
                {
                    Console.Write(numbers[i] + ", ");

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Select one of the options:");
                Console.WriteLine("1. Sort List");
                Console.WriteLine("2. Make New List of Random Numbers");
                Console.WriteLine("3. Remove a Number");
                Console.WriteLine("4. Add Value to List");
                Console.WriteLine("5. Count # of Occurence of Value");
                Console.WriteLine("6. Print Largest Value");
                Console.WriteLine("7. Print Smallest Value");
                Console.WriteLine("8. Print middle number of list");
                Console.WriteLine("9. Quit");

                user = Convert.ToInt32(Console.ReadLine());

                if (user == 1)
                {
                    numbers.Sort();
                }
                else if (user == 2)
                {
                    //Not sure if you want a new list or replace the list with new numbers
                    //To replace same list with new numbers, use the following code 
                    /* numbers.Clear();
                     * for (int j = 0; j < 25; j++)
                    {
                        numbers.Add(generator.Next(10, 21));
                        Console.Write(numbers[j] + ", ");
                    }*/
                    List<int> numbersNew = new List<int>();

                    for (int j = 0; j < 25; j++)
                    {
                        numbersNew.Add(generator.Next(10, 21));
                        Console.Write(numbersNew[j] + ", ");
                    }

                    Console.ReadLine();
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

                    Console.ReadLine();


                }
                else if (user == 6)
                {
                    numbers.Sort();
                    Console.WriteLine($"The largest value in the list is {numbers[numbers.Count - 1]}.");
                    Console.ReadLine();

                }
                else if (user == 7)
                {
                    numbers.Sort();
                    Console.WriteLine($"The smallest value in the list is {numbers[0]}");
                    Console.ReadLine();

                }
                else if (user == 8)
                {
                    numbers.Sort();
                    Console.WriteLine($"The middle value of the list is {numbers[numbers.Count / 2]}");
                    Console.ReadLine();

                }
            }
            Console.WriteLine("Thanks for using this application!");
        }
    }
}