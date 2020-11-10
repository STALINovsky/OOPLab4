using System;
using System.Collections.Generic;
using System.Text;
using TaskLibrary.Base;

namespace OOPLab4.View
{
    public class ConsoleInputService : IInputService
    {
        public ConsoleInputService(ILoggerService loggerService)
        {
            LoggerService = loggerService;
        }
        private ILoggerService LoggerService { get; }

        public int GetNumber()
        {
            var input = Console.ReadLine();
            int result;
            while (!int.TryParse(input, out result))
            {
                LoggerService.LogError("Invalid input");
            }
            return result;
        }

        public string GetString()
        {
            return Console.ReadLine();
        }

        public IList<object> GetExerciseArgs(ArgsOption argsOption)
        {
            var args = new List<object>();

            foreach (var stringTypePair in argsOption)
            {
                object arg;
                LoggerService.LogMessage(stringTypePair.Value);
                switch (stringTypePair.Key)
                {
                    case ExerciseType.Integer:
                        arg = GetNumber();
                        break;
                    case ExerciseType.String:
                        arg = GetString();
                        break;
                    default:
                        throw new InvalidOperationException($"Can not input type {stringTypePair.Key}");
                }
                args.Add(arg);
            }

            return args;
        }
    }
}
