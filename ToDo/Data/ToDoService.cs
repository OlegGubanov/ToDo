using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDo.Data
{
    public class ToDoService
    {
        private ToDoRepository ToDoRepository;
        public ToDoService(ToDoRepository toDoRepository)
        {
            this.ToDoRepository = toDoRepository;
        }

        public async Task<ToDoItem> Get(int id)
        {
            return await ToDoRepository.Get(id);
        }

        public async Task<List<ToDoItem>> GetAll()
        {
            return await ToDoRepository.GetAll();
        }

        public async Task Add(ToDoItem item)
        {
            await ToDoRepository.Add(item);
        }

        public async Task Delete(int id)
        {
            await ToDoRepository.Delete(id);
        }

        public async Task Update(ToDoItem item)
        {
            await ToDoRepository.Update(item);
        }

    }
}
