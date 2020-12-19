using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;

namespace TaskLibrary.MainExercises
{
    public class Exercise3 : BaseExercise
    {
        private const string NumberArgumentName = "number";

        public override string Name { get; } = "is the number a multiple 2, 3, 5, 7, 11, 13, 17 and 19";
        public override string Description { get; } = "a program that would determine whether a given number is " +
                                                      "multiples of the corresponding numbers 2, 3, 5, 7, 11, 13, 17 and 19.";

        public Exercise3()
        {
            ArgumentsDescriptions = new List<ExerciseArgDescription>()
            {
                new ExerciseArgDescription(NumberArgumentName, ExerciseArgumentType.Integer)
            };
        }

        public override IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }

        private static readonly int[] Dividers = { 2, 3, 5, 7, 11, 13, 17, 19 };
        public override string Invoke()
        {
            int number = (int)base.NameValueArgDictionary[NumberArgumentName];

            var answerBuilder = new StringBuilder();
            foreach (var divider in Dividers)
            {
                if (number % divider == 0)
                {
                    answerBuilder.AppendLine($"number {number} divides by {divider}");
                }
            }

            return answerBuilder.ToString();
        }
    }
}
