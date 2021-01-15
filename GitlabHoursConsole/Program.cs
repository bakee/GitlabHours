using System;
using GitlabHoursLib;

namespace GitlabHoursConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() == "exit")
                {
                    return;
                }

                var output = new HourConverter().Convert(userInput);
                Console.WriteLine(output);
            }
        }
    }
}
