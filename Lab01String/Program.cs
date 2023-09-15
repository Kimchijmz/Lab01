using System.Text.RegularExpressions;

namespace Lab01String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("**********************");
            Console.WriteLine("     WELCOME TO       ");
            Console.WriteLine(" - FIND REPEATING -   ");
            Console.WriteLine("**********************");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine(" Please write a string of choice with numbers and/or letters : ");
            string userInput = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" * press q to quit * ");
            Console.ResetColor();


            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(" Insert the number or letter you´d like to find the repeating of : ");
                string number = Console.ReadLine();

                string find = number;
                Match repeating1 = Regex.Match(userInput,find);

                if (repeating1.Success)
                {
                    int findRepeating = repeating1.Index;

                    Match repeating2 = Regex.Match(userInput.Substring(findRepeating + 1), find);

                    if (repeating2.Success)
                    {
                        int result = findRepeating + repeating2.Index + repeating2.Length + 1;

                        Console.Write(userInput.Substring(0, findRepeating));
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(userInput.Substring(findRepeating, result - findRepeating));
                        Console.ResetColor();
                        Console.WriteLine(userInput.Substring(result));

                        if (userInput == "q" || userInput == "Q") break;
                    }
                    else
                    {
                        Console.WriteLine("No repeating number found.. try again!");
                      
                    }
                }
                else 
                {
                    break;
                }

            }
        }
    }
}