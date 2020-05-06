using System.Collections.Generic;

namespace Beceps.History
{
    public class ExerciseHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<int> RepsAmounts { get; set; }
    }
}