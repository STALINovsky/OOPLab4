using System;
using System.Collections.Generic;
using System.Text;
using OOPLab4.View.Interfaces;
using TaskLibrary.Base;

namespace OOPLab4.View
{
    public class ConsoleInputService : IInputService
    {
        public ConsoleInputService(IOutputService outputService)
        {
            OutputService = outputService;
        }
        private IOutputService OutputService { get; }

        public int GetNumber()
        {
            var input = Console.ReadLine();
            int result;
            while (!int.TryParse(input, out result))
            {
                OutputService.LogError("Invalid input. Try again");
                input = Console.ReadLine();
            }
            return result;
        }

        public List<int> GetArrayOfNumbers()
        {
            List<int> numbers = new List<int>();
            OutputService.LogMessage("To stop input array please press enter");

            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == "")
                {
                    break;
                }

                if (!int.TryParse(userInput, out var newNumber))
                {
                    OutputService.LogError("Invalid input.Try again");
                }
                else
                {
                    numbers.Add(newNumber);
                }
            }

            return numbers;
        }

        public bool IsUserAgree()
        {
            const string yesAnswer = "yes";
            OutputService.LogMessage("enter yes or no");
            return Console.ReadLine().Contains(yesAnswer);
        }
    }
}
