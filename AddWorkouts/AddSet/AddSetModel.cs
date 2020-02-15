using System.ComponentModel.DataAnnotations;

namespace Beceps.AddWorkouts.AddSet
{
    public class AddSetModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
        [Required]
        [Range(1, 10)]
        public int SetsAmount { get; set; } = 1;
        [Required]
        [Range(1, 100)]
        public int RepsAmount { get; set; } = 1;

        public void Reset()
        {
            Name = "";
            SetsAmount = 1;
            RepsAmount = 1;
        }
    }
}
