namespace Beceps.Workout.RoutineProgress
{
    public class SetModel
    {
        public string Name { get; set; }
        public string Amount { get; set; } = "...";

        public SetModel(string name)
        {
            Name = name;
        }
    }
}
