using System.ComponentModel.DataAnnotations;

namespace ModelBindingPractice_Pet.Models
{
    /// <summary>
    /// this class represents a pet, Id is the primary key
    /// </summary>
    public class Pet
    {
        public int Id { get; set; }
        [StringLength(20)]
        [Required(ErrorMessage = "Enter valid name")]
        public required string Name { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Enter valid species")]
        public required string Species { get; set; }
        [Range(0, 25)] //Assume age in years, 0-25 is a reasonable range for pets
        public int Age { get; set; }
        public bool IsFixed { get; set; }
    }
}
