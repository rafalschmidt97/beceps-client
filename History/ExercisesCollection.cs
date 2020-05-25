using System.Collections.Generic;

namespace Beceps.History
{
    public class ExercisesCollection
    {
        public IList<ExerciseDto> Exercises { get; set; } = new List<ExerciseDto>();

        public ExercisesCollection(IList<WorkoutHistory> workouts, string workoutName)
        {
            foreach (var workout in workouts)
            {
                if (workout.Name == workoutName)
                {
                    foreach (var routine in workout.Routines)
                    {
                        foreach (var set in routine.Sets)
                        {
                            if (set.Exercises.Count != 0)
                            {
                                var exerciseDto = new ExerciseDto
                                {
                                    Name = set.Name,
                                    Id = set.Id
                                };
                                foreach (var exercise in set.Exercises)
                                {
                                    exerciseDto.Reps.Add(exercise.Reps);
                                }
                                Exercises.Add(exerciseDto);
                            }
                        }
                    }
                }
            }
        }
    }
}
