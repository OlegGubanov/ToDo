using Microsoft.EntityFrameworkCore;
using System;

namespace ToDo.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options)
        {

        }
    }
}
