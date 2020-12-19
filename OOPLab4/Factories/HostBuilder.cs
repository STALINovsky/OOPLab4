using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLab4.View.Interfaces;
using TaskLibrary.Base;
using TaskLibrary.MainExercises;
using TaskLibrary;

namespace OOPLab4.Factories
{
    public static class ExerciseFactory
    {
        public static List<IExercise> CreateExercises()
        {
            List<IExercise> exercises = new List<IExercise>()
            {
                //Main Exercises
                new Exercise1(),
                new Exercise2(),
                new Exercise3(),
                //A part
                new TaskLibrary.ExercisesOfPartA.Exercise1(),
                //B part
                new TaskLibrary.ExercisesOfPartB.Exercise1(),
            };

            return exercises;
        }
    }
}
