using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskLibrary.Base;

namespace OOPLab4.View.Interfaces
{
    public interface IOutputService
    {
        public void LogMessage(string message);

        public void LogResult(string result);
        public void LogError(string error);
        public void LogExercises(IEnumerable<IExercise> exercises);
    }
}
