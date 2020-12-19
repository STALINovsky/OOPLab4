using System;
using System.Collections.Generic;
using OOPLab4.Factories;
using OOPLab4.Hosts;
using OOPLab4.View;
using OOPLab4.View.Interfaces;
using TaskLibrary.Base;

namespace OOPLab4
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IOutputService output = new ConsoleOutputService();
            IInputService inputService = new ConsoleInputService(output);

            var exercises = ExerciseFactory.CreateExercises();
            var host = new Host(output,inputService,exercises);

            host.Run();
        }
    }
}
