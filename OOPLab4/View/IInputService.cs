using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;

namespace OOPLab4.View
{
    public interface IInputService
    {
        public int GetNumber();
        public IList<object> GetExerciseArgs(ArgsOption argsOption);
    }
}
