using System;
using System.Collections.Generic;
using System.Text;
using OOPLab4.View.Interfaces;
using TaskLibrary.Base;

namespace OOPLab4.View
{
    class ConsoleOutputService : IOutputService
    {
        private const ConsoleColor DefaultColor = ConsoleColor.White; 
        private const ConsoleColor MessageColor = ConsoleColor.White; 
        private const ConsoleColor ErrorColor = ConsoleColor.Red;
        private const ConsoleColor ResultColor = ConsoleColor.Green;
        
        public void LogMessage(string message)
        {
            Console.ForegroundColor = MessageColor;
            Console.WriteLine(message);
            Console.ForegroundColor = DefaultColor;
        }

        public void LogResult(string result)
        {
            Console.ForegroundColor = ResultColor;
            Console.WriteLine(result);
            Console.ForegroundColor = DefaultColor;
        }

        public void LogError(string error)
        {
            Console.ForegroundColor = ErrorColor;
            Console.WriteLine(error);
            Console.ForegroundColor = DefaultColor;
        }

        public void LogExercises(IEnumerable<IExercise> exercises)
        {
            int index = 1;
            foreach (var exercise in exercises)
            {
                Console.WriteLine($"{index++} - {exercise.Name}");
            }
        }
    }
}
