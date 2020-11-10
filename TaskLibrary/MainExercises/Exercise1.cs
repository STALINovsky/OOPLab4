using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;

namespace TaskLibrary.MainExercises
{
    class Exercise1 : IExercise
    {
        public string Description { get; } = "At a young age, the dragon grows three heads every year," +
                                             " but after when he turns 200 years old - only two," +
                                             " and after 300 years - only one. " +
                                             "Develop a program that calculates how many goals and the eye of a dragon that is N years old." +
                                             " Consider that at birth the dragon has already three heads.";

        public ArgsOption ArgsOption { get; } = new ArgsOption() { { "Please enter N", typeof(Int32) } };

        public string Invoke(IList<object> args)
        {
            const int initDragonHeadsCount = 3;
            int yearsToCalculate = (int)args[0];

            if (yearsToCalculate < 0)
            {
                throw new ArgumentException("years must be > 0");
            }

            int dragonHeadsCount = initDragonHeadsCount;

            const int firstAge = 200;
            const int firstAgeIncrement = 3;
            if (yearsToCalculate > 0)
            {
                dragonHeadsCount += (yearsToCalculate % firstAge) * firstAgeIncrement;
                yearsToCalculate -= firstAge;
            }

            const int secondAge = 300;
            const int secondAgeIncrement = 2;
            if (yearsToCalculate > firstAge)
            {
                dragonHeadsCount += (yearsToCalculate % secondAge) * secondAgeIncrement;
                yearsToCalculate -= secondAge;
            }

            const int lastAgeIncrement = 1;
            if (yearsToCalculate > secondAge)
            {
                dragonHeadsCount += (yearsToCalculate % secondAge) * lastAgeIncrement;
            }

            return $"Dragon Heads count = {dragonHeadsCount}";
        }
    }
}
