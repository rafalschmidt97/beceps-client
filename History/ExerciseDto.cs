using System.Collections.Generic;

namespace Beceps.History
{
    public class ExerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<int> Reps { get; set; } = new List<int>();
    }
}