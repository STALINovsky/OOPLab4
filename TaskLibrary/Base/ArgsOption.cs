using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Base
{
    public class ArgsOption : Dictionary<ExerciseType, string>
    {

    }

    public enum ExerciseType
    {
        Integer,
        String
    }
}
