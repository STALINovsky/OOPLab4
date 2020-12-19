using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TaskLibrary.Base;

namespace TaskLibrary.ExercisesOfPartB
{
    public class Exercise1 : BaseExercise
    {
        private const string RatingArgName = "Rating";

        public override string Name { get; } = "evaluator";
        public override string Description { get; } = "Describes your grade";
        public override IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }
        
        public Exercise1()
        {
            ArgumentsDescriptions = new List<ExerciseArgDescription>()
            {
                new ExerciseArgDescription(RatingArgName, ExerciseArgumentType.Integer)
            };

        }

        public override string Invoke()
        {
            const int minRating = 0;
            const int maxRating = 10;
            int rating = (int)base.NameValueArgDictionary[RatingArgName];

            if (rating < minRating || rating > maxRating)
            {
                throw new ArgumentException("invalid rating");
            }

            return rating switch
            {
                1 => "dam boi",
                2 => "double kill",
                3 => "triple kill ",
                4 => "quad kill",
                5 => "Rampage ",
                6 => "This is bad",
                7 => "This is bad",
                8 => "that's fine",
                9 => "good",
                10 => "surpass the gods",
            };

            
        }
    }
}
