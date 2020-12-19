using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TaskLibrary.Base;

namespace TaskLibrary.ExercisesOfPartA
{
    public class Exercise1 : BaseExercise
    {
        private const string FirstSideArgName = "First Side";
        private const string SecondSideArgName = "Second Side";
        private const string ThirdSideArgName = "Third Side";

        public override string Name { get; } = "are 3 numbers sides of a triangle";
        public override string Description { get; } = "Program checks if 3 numbers are sides of a triangle";

        public override IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }


        public Exercise1()
        {
            ArgumentsDescriptions = new List<ExerciseArgDescription>()
            {
                new ExerciseArgDescription (FirstSideArgName, ExerciseArgumentType.Integer),
                new ExerciseArgDescription (SecondSideArgName, ExerciseArgumentType.Integer),
                new ExerciseArgDescription (ThirdSideArgName, ExerciseArgumentType.Integer)
            };
        }

        public override string Invoke()
        {
            int a = (int)NameValueArgDictionary[FirstSideArgName];

            int b = (int)NameValueArgDictionary[SecondSideArgName];

            int c = (int)NameValueArgDictionary[ThirdSideArgName];

            bool isTriangle = a < b + c && b < a + c && c < a + b;
            return isTriangle ? "Yes. They are" : "No. They aren't";
        }
    }
}
