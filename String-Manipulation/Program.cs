using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the String Manipulation Console App!");

            while (true)
            {
                Console.WriteLine("\nPlease select a string manipulation operation:");
                Console.WriteLine("1. String length");
                Console.WriteLine("2. Substring");
                Console.WriteLine("3. Concatenation");
                Console.WriteLine("4. Replace");
                Console.WriteLine("5. Split");
                Console.WriteLine("6. To Upper Case");
                Console.WriteLine("7. To Lower Case");
                Console.WriteLine("8. Trim");
                Console.WriteLine("9. Quit");

                int selection;
                if (!int.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }

                if (selection == 9)
                {
                    break;
                }

                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"String length: {input.Length}");
                        break;
                    case 2:
                        Console.WriteLine("Enter a starting index:");
                        int startIndex;
                        if (!int.TryParse(Console.ReadLine(), out startIndex) || startIndex < 0 || startIndex >= input.Length)
                        {
                            Console.WriteLine("Invalid starting index. Please try again.");
                            continue;
                        }

                        Console.WriteLine("Enter a length:");
                        int length;
                        if (!int.TryParse(Console.ReadLine(), out length) || length < 0 || startIndex + length > input.Length)
                        {
                            Console.WriteLine("Invalid length. Please try again.");
                            continue;
                        }

                        Console.WriteLine($"Substring: {input.Substring(startIndex, length)}");
                        break;
                    case 3:
                        Console.WriteLine("Enter a string to concatenate:");
                        string toConcat = Console.ReadLine();
                        Console.WriteLine($"Concatenation result: {string.Concat(input, toConcat)}");
                        break;
                    case 4:
                        Console.WriteLine("Enter the string to replace:");
                        string toReplace = Console.ReadLine();
                        Console.WriteLine("Enter the replacement string:");
                        string replacement = Console.ReadLine();
                        Console.WriteLine($"Replace result: {input.Replace(toReplace, replacement)}");
                        break;
                    case 5:
                        Console.WriteLine("Enter the delimiter:");
                        string delimiter = Console.ReadLine();
                        string[] splitResult = input.Split(delimiter[0]);
                        Console.WriteLine("Split result:");
                        foreach (string str in splitResult)
                        {
                            Console.WriteLine(str);
                        }
                        break;
                    case 6:
                        Console.WriteLine($"To Upper Case result: {input.ToUpper()}");
                        break;
                    case 7:
                        Console.WriteLine($"To Lower Case result: {input.ToLower()}");
                        break;
                    case 8:
                        Console.WriteLine($"Trim result: {input.Trim()}");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
        }
    }
}
