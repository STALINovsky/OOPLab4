using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Base
{
    public class ExerciseArgDescription
    {
        public ExerciseArgumentType Type { get; }
        public string ArgName { get; }

        internal ExerciseArgDescription(string argName, ExerciseArgumentType type)
        {
            this.ArgName = argName;
            this.Type = type;
        }
    }
}
