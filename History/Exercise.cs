namespace Beceps.History
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Reps { get; set; }

        public Exercise()
        {

        }

        public Exercise(Exercise exercise, string name)
        {
            Id = exercise.Id;
            Reps = exercise.Reps;
            Name = name;
        }
    }
}