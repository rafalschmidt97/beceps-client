using System.Collections.Generic;

namespace Beceps.Shared
{
    public class WorkoutDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<RoutineDto> Routines { get; set; }
    }
}
