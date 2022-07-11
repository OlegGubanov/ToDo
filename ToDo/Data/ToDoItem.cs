using System;

namespace ToDo.Data
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime DoneTime { get; set; }
        public bool IsDone { get; set; }

        public ToDoItem(string title)
        {
            Title = title;
            Description = null;
            CreatedTime = DateTime.Now;
            DoneTime = DateTime.MinValue;
            IsDone = false;
        }
    }
}
