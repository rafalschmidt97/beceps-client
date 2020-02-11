using System.ComponentModel.DataAnnotations;

namespace Beceps.Workout.Pages
{
    public class AddWorkoutModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
}
