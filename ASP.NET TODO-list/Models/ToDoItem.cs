namespace ASP.NET_TODO_list.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? Description { get; set; } 
        public bool IsCompleted { get; set; }
        public string Priority { get; set; } = "Medium"; 
        public DateTime DueTime { get; set; } = DateTime.Now.AddDays(1); 
    }
}
