namespace TodoList.Domain.Entities
{
    public class Task
    {
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; private set; }
        public bool IsCompleted { get; private set; } = false;

        public Task(Guid id, string title, string description, bool isCompleted)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
        }

        public Task(Guid id, string title, string description, DateTime dueDate, bool isCompleted) : this(id, title, description, isCompleted)
        {
            DueDate = dueDate;
        }

        // EF CORE
        public Task()
        {
            
        }

        public void ChangeDueDate(DateTime dueDate)
        {
            DueDate = dueDate;
        }

        public void Complete()
        {
            IsCompleted = true;
        }
    }
}