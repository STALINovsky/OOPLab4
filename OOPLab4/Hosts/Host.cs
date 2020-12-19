using System;
using System.Collections.Generic;
using OOPLab4.View.Interfaces;
using TaskLibrary.Base;

namespace OOPLab4.Hosts
{
    public class Host : IHost
    {
        private const int ExitInput = 0;
        private static string MenuDescription { get; } = $"To exit input {ExitInput}\n" +
                                                         $"To run exercise input index of exercise";

        private IOutputService OutputService { get; }
        private IInputService InputService { get; }
        private IReadOnlyList<IExercise> Exercises { get; }

        public Host(IOutputService outputService, IInputService inputService,
            IReadOnlyList<IExercise> exercises)
        {
            OutputService = outputService;
            InputService = inputService;
            Exercises = exercises;
        }

        private void ShowMenu()
        {
            OutputService.LogMessage(MenuDescription);
            OutputService.LogExercises(Exercises);
        }

        private IExercise GetExerciseByIndexOrDefault(int index)
        {
            if (index >= 0 && index < Exercises.Count)
            {
                return Exercises[index];
            }
            return null;
        }

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
                    InvokeExercise(exercise);
                }
                else
                {
                    OutputService.LogError("Error: Wrong input!");
                }
            }
        }

        public IExercise InitExercise(IExercise exercise)
        {
            foreach (var argDescription in exercise.ArgumentsDescriptions)
            {
                OutputService.LogMessage($"please enter {argDescription.ArgName}");
                object value = argDescription.Type switch
                {
                    ExerciseArgumentType.Integer => InputService.GetNumber(),
                    ExerciseArgumentType.ArrayOfInteger => InputService.GetArrayOfNumbers(),
                    _ => throw new ArgumentException("Invalid exercise Argument")
                };
                exercise.AddExerciseArgument(argDescription.ArgName, value);
            }
            return exercise;
        }

        private void InvokeExercise(IExercise exercise)
        {
            bool retry = true;
            while (retry)
            {
                retry = false;
                try
                {
                    exercise = InitExercise(exercise);
                    OutputService.LogResult(exercise.Invoke());
                }
                catch (Exception e)
                {
                    OutputService.LogError(e.Message);
                    OutputService.LogMessage("do you want to try again?");
                    retry = InputService.IsUserAgree();
                }
            }
        }
    }
}
