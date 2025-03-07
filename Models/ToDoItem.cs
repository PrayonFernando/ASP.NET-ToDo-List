namespace ASP.NET_TODO_list.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public string Priority { get; set; } 
        public DateTime DueTime { get; set; } 
    }
}
