namespace ASP.NET_TODO_list.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; } // Make nullable
        public string? Description { get; set; } // Make nullable
        public bool IsCompleted { get; set; }
        public string Priority { get; set; } = "Medium"; // Default value
        public DateTime DueTime { get; set; } = DateTime.Now.AddDays(1); // Default value
    }
}
