namespace TodoList.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; private set; } = false;

        public Task(Guid id, string title, string description, DateTime dueDate, bool isCompleted)
        {
            Id = id;
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        // EF CORE
        public Task()
        {
            
        }

        public void Complete()
        {
            IsCompleted = true;
        }
    }
}