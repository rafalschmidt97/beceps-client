using Beceps.Utilities.AutomaticDependencyInjection;

namespace Beceps.AddWorkouts
{
    public interface IWorkoutState : ISingleton
    {
        public int WorkoutId { get; set; }
        public int RoutineId { get; set; }
    }
}