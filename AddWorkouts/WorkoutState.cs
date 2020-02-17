using Beceps.Utilities.AutomaticDependencyInjection;

namespace Beceps.AddWorkouts
{
    public class WorkoutState : ISingleton
    {
        public int WorkoutId { get; set; }
        public int RoutineId { get; set; }
    }
}
