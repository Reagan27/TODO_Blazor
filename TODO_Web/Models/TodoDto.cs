namespace TODO_Web.Models
{
    public class TodoDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;

        public bool IsDone { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}