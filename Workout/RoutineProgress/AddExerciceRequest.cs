namespace Beceps.Workout.RoutineProgress
{
    public class AddExerciseRequest
    {
        public int Reps { get; set; }
        public int SetId { get; set; }

        public AddExerciseRequest(int reps, int setId)
        {
            Reps = reps;
            SetId = setId;
        }

        public AddExerciseRequest() { }
    }
}
