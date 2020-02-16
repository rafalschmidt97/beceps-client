using System.Collections.Generic;

namespace Beceps.Shared.Domain
{
    public class RoutineDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public WeekDay WeekDay { get; set; }
        public IList<SetDto> Sets { get; set; }
    }
}
