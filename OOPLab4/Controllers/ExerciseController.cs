using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using OOPLab4.View;
using TaskLibrary;
using TaskLibrary.Base;

namespace OOPLab4.Controllers
{
    public class ExerciseController
    {
        public ExerciseController(ILoggerService loggerService, IInputService inputService, IReadOnlyList<IExercise> exercises)
        {
            LoggerService = loggerService;
            InputService = inputService;
            Exercises = exercises;
        }

        private ILoggerService LoggerService { get; }
        private IInputService InputService { get; }
        private IReadOnlyList<IExercise> Exercises { get; }

        private const int ExitInput = 0;
        private readonly string MenuDescription = $"To exit input {ExitInput}\n" +
                                                  $"To run exercise input index of exercise";

        public void Run()
        {
            while (true)
            {
                ShowMenu();
                int key = InputService.GetNumber();
                if (key == 0) break;

                IExercise exercise = GetExerciseByIndexOrDefault(key - 1);
                if (exercise != null)
                {
                    RunExercise(exercise);
                }
                else
                {
                    LoggerService.LogError("Error: Wrong input!");
                }
            }
        }

        private IExercise GetExerciseByIndexOrDefault(int index)
        {
            if (index >= 0 && index < Exercises.Count)
            {
                return Exercises[index];
            }
            return null;
        }

        private void ShowMenu()
        {
            LoggerService.LogMessage(MenuDescription);
            LoggerService.LogExercises(Exercises);
        }

        private void RunExercise(IExercise exercise)
        {
            try
            {
                var exerciseArgs = InputService.GetExerciseArgs(exercise.ArgsOption);
                string taskResultString = exercise.Invoke(exerciseArgs);
                LoggerService.LogMessage(taskResultString);
            }
            catch (Exception e)
            {
                LoggerService.LogError(e.Message);
                throw;
            }
        }
    }
}
