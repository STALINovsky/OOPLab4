using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Base
{
    public interface IExercise
    {
        string Name { get; }
        string Description { get; }

        IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }
        void AddExerciseArgument(string name, object value);
        string Invoke();
    }

}
