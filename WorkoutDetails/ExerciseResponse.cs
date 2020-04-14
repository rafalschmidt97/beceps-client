using Beceps.Shared.Domain;
using System.Collections.Generic;

namespace Beceps.WorkoutDetails
{
    public class ExerciseResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Routine Routine { get; set; }
    }

    public class Routine
    {
        public int Id { get; set; }
        public WeekDay WeekDay { get; set; }
        public IList<Set> Sets { get; set; }
    }

    public class Set
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SetsAmount { get; set; }
        public int RepsAmount { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }

    public class Exercise
    {
        public int Id { get; set; }
        public int Reps { get; set; }
    }
}
