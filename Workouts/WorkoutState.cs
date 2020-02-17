using Beceps.Shared.Domain;
using Beceps.Utilities.AutomaticDependencyInjection;
using System.Collections.Generic;

namespace Beceps.Workouts
{
    public class WorkoutState : ISingleton
    {
        public IList<WorkoutDto> Workouts { get; set; }
    }
}
