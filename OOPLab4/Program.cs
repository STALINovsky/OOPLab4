using System;
using System.Collections.Generic;
using OOPLab4.Controllers;
using OOPLab4.View;
using TaskLibrary.Base;

namespace OOPLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService logger = new ConsoleLoggerService();
            IInputService inputService = new ConsoleInputService(logger);
            var exercises = InstanceExercises();

            var controller = new ExerciseController(logger,inputService,);
        }

        public static List<IExercise> InstanceExercises()
        {
            var exercises = new List<IExercise>();
            //TODO:Fill exercises
            return exercises;
        }
    }
}
