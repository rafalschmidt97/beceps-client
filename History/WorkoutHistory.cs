using System.Collections.Generic;

namespace Beceps.History
{
    public class WorkoutHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<RoutineHistory> Routines { get; set; }
    }
}
