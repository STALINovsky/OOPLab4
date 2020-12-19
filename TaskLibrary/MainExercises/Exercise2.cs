using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TaskLibrary.Base;
namespace TaskLibrary.MainExercises
{
    public class Exercise2 : BaseExercise
    {
        private const string NumbersArgumentName = "Numbers";

        public override string Name => "The Greatest";
        public override string Description => "the program determines which of the values ​​entered by the user is the largest" +
                                                      "(the fewest).Provide for the possibility of equality of all values.";
        public override IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }

        public Exercise2()
        {
            ArgumentsDescriptions = new List<ExerciseArgDescription>()
            {
                new ExerciseArgDescription(NumbersArgumentName, ExerciseArgumentType.ArrayOfInteger)
            };
        }

        public override string Invoke()
        {
            var numbers = (IReadOnlyList<int>)base.NameValueArgDictionary[NumbersArgumentName];
            if (numbers.Count == 0)
            {
                throw new ArgumentException("Array can't be empty");
            }

            if (numbers.All(x => x == numbers[0]))
            {
                return "All numbers are equals";
            }


            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            return $"min number = { minNumber }, max number = { maxNumber }";
        }
    }
}
