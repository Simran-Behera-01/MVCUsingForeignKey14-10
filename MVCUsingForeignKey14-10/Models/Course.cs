namespace MVCUsingForeignKey14_10.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }

        public int TrainerId { get; set; }  
        public Trainer Trainer { get; set; }    
    }
}
