namespace ModelBindingPractice_Pet.Models
{
    /// <summary>
    /// this class represents a pet, Id is the primary key
    /// </summary>
    public class Pet
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Species { get; set; }
        public int Age { get; set; }
        public bool IsFixed { get; set; }
    }
}
