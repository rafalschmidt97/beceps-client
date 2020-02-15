namespace Beceps.AddWorkouts.AddSet
{
    public class AddSetRequest
    {
        public string Name { get; private set; }
        public int? SetsAmount { get; private set; }
        public int? RepsAmount { get; private set; }
        public int RoutineId { get; private set; }

        public AddSetRequest(string name, int setsAmount, int repsAmount, int routineId)
        {
            Name = name;
            SetsAmount = setsAmount;
            RepsAmount = repsAmount;
            RoutineId = routineId;
        }
    }
}
