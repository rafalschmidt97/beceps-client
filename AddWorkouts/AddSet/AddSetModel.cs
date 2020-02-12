using System.ComponentModel.DataAnnotations;

namespace Beceps.AddWorkouts.AddSet
{
    public class AddSetModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        [Required]
        [Range(0, 10)]
        public int? NumberOfSets { get; set; }
        [Required]
        [Range(0, 100)]
        public int? NumberOfReps { get; set; }
    }
}
