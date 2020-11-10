using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;

namespace OOPLab4.View
{
    public interface ILoggerService
    {
        void LogMessage(string message);
        void LogResult(string result);
        void LogError(string error);

        void LogExercises(IEnumerable<IExercise> exercises);
    }
}
