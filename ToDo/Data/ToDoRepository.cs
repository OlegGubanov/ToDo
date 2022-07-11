using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Data
{
    public class ToDoRepository
    {
        private ToDoContext db;

        public ToDoRepository(ToDoContext db)
        {
            this.db = db;
        }

        public async Task<ToDoItem> Get(int id)
        {
            return await db.ToDoItems.FirstOrDefaultAsync(item => item.Id == id);
        }

        public async Task<List<ToDoItem>> GetAll()
        {
            return await db.ToDoItems.ToListAsync();
        }   

        public async Task Add(ToDoItem item)
        {
            await db.ToDoItems.AddAsync(item);
            await db.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var item = await db.ToDoItems.FirstOrDefaultAsync(item => item.Id == id);
            if (item != null)
            {
                db.ToDoItems.Remove(item);
                await db.SaveChangesAsync();
            }
        }

        public async Task Update(ToDoItem item)
        {
            db.ToDoItems.Update(item);
            await db.SaveChangesAsync();
        }
    }
}
