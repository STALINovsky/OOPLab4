using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLibrary.Base
{
    public interface IExercise
    {
        string Description { get; }

        ArgsOption ArgsOption { get; }
        string Invoke(IList<object> args);
    }
}
