using System.ComponentModel.DataAnnotations;

namespace Beceps.AddWorkouts.AddWorkout
{
    public class AddWorkoutModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
}
