namespace Beceps.AddWorkouts.AddRoutine
{
    public class AddRoutineRequest
    {
        public string Name { get; private set; }
        public int WeekDay { get; private set; }
        public int WorkoutId { get; private set; }

        public AddRoutineRequest(string name, int weekDay, int workoutId)
        {
            Name = name;
            WeekDay = weekDay;
            WorkoutId = workoutId;
        }
    }
}
