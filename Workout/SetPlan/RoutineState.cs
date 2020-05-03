using Beceps.Shared.Domain;
using Beceps.Utilities.AutomaticDependencyInjection;
using Beceps.Workout.RoutineProgress;
using System.Collections.Generic;

namespace Beceps.Workout.SetPlan
{
    public class RoutineState : ISingleton
    {
        public List<SetModel> Sets { get; set; } = new List<SetModel>();
        public int CurrentSetIndex { get; set; } = 1;
        public SetDto Set { get; set; }
    }
}
