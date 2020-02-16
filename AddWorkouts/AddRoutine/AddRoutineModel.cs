using Beceps.Shared.Domain;
using System.ComponentModel.DataAnnotations;

namespace Beceps.AddWorkouts.AddRoutine
{
    public class AddRoutineModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        [Range(1,7, ErrorMessage = "Please choose a day.")]
        public WeekDay WeekDay { get; set; }
    }
}
