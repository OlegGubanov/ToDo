using System.Collections;
using System.Collections.Generic;

namespace ToDo.Data
{
    public class ToDoItemComparer : IComparer<ToDoItem>
    {
        public int Compare(ToDoItem item1, ToDoItem item2)
        {
            return CompareByStatus(item1, item2);
        }

        private int CompareByStatus(ToDoItem item1, ToDoItem item2)
        {
            if (!item1.IsDone && item2.IsDone)
                return -1;
            else if (item1.IsDone && !item2.IsDone)
                return 1;
            else
                return CompareByCreatedTime(item1, item2);
        }

        private int CompareByCreatedTime(ToDoItem item1, ToDoItem item2)
        {
            if (item1.IsDone && item2.IsDone)
                return item2.DoneTime.CompareTo(item1.DoneTime);
            else
                return item2.CreatedTime.CompareTo(item1.CreatedTime);
        }
    }
}
