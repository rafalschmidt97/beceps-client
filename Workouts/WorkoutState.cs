using Beceps.Shared;
using System.Collections.Generic;

namespace Beceps.Workouts
{
    public class WorkoutState : IWorkoutState
    {
        public IList<WorkoutDto> Workouts { get; set; }
    }
}
