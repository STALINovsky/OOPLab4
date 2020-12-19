using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Base
{
    public abstract class BaseExercise : IExercise
    {
        protected BaseExercise()
        {
            NameValueArgDictionary = new Dictionary<string, object>();
        }

        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract IReadOnlyCollection<ExerciseArgDescription> ArgumentsDescriptions { get; }

        protected Dictionary<string, object> NameValueArgDictionary { get; }

        public void AddExerciseArgument(string name, object value)
        {
            if (NameValueArgDictionary.ContainsKey(name))
            {
                NameValueArgDictionary[name] = value;
            }
            else
            {
                NameValueArgDictionary.Add(name, value);
            }
        }
        public abstract string Invoke();
    }
}
