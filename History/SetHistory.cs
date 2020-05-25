using System.Collections.Generic;

namespace Beceps.History
{
    public class SetHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Exercise> Exercises { get; set; }
    }
}