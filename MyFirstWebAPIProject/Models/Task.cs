namespace MyFirstWebAPIProject.Models
{
    public class Task
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string Title { get; set; }
        public string Diskription { get; set; }
    }
}
