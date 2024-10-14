namespace MVCUsingForeignKey14_10.Models
{
    public class Trainer
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
