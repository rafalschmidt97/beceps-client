using System;
using System.ComponentModel.DataAnnotations;

namespace Beceps.AddWorkouts.AddRoutine
{
    public class AddRoutineModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }

        [Required]
        public DayOfWeek WeekDay { get; set; }
    }
}
