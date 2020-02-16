using Beceps.Shared.Domain;
using Beceps.Utilities.AutomaticDependencyInjection;
using System.Collections.Generic;

namespace Beceps.Workouts
{
    public interface IWorkoutState : ISingleton
    {
        IList<WorkoutDto> Workouts { get; set; }
    }
}