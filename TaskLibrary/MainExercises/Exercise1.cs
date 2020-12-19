using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;
namespace TaskLibrary.MainExercises
{
    public class Exercise1 : BaseExercise
    {
        private const string DragonAgeArgName = "Dragon age";
        public Exercise1()
        {
            ArgumentsDescriptions = new List<ExerciseArgDescription>()
            {
                new ExerciseArgDescription(DragonAgeArgName, ExerciseArgumentType.Integer)
            };
        }

        public override string Name { get; } = "Dragon Heads";
        public override string Description { get; } = "At a young age, the dragon grows three heads every year," +
                                                      " but after when he turns 200 years old - only two," +
                                                      " and after 300 years - only one. " +
                                                      "Develop a program that calculates how many goals and the eye of a dragon that is N years old." +
                                                      " Consider that at birth the dragon has already three heads.";

        public override IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }
        private static readonly Dictionary<int, int> PeriodIncrementDictionary
            = new Dictionary<int, int>()
            {
                {200,3},
                {100,2},
                {int.MaxValue, 1}
            };
        private const int InitialDragonHeadsCount = 3;



        public override string Invoke()
        {
            int dragonAge = (int)(base.NameValueArgDictionary[DragonAgeArgName]);
            if (dragonAge < 0)
            {
                throw new ArgumentException("Dragon year must be greater than 0");
            }

            int dragonHeadsCount = InitialDragonHeadsCount;

            int yearsToCalculate = dragonAge;
            foreach (var periodIncrementPair in PeriodIncrementDictionary)
            {
                if (yearsToCalculate > 0)
                {
                    int period = periodIncrementPair.Key;
                    int increment = periodIncrementPair.Value;
                    dragonHeadsCount += (yearsToCalculate % (period + 1)) * increment;
                    yearsToCalculate -= period;
                }
            }

            return $"The dragon will have {dragonHeadsCount} heads ";
        }


    }
}
