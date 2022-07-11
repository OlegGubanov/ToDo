using HotChocolate;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Data;

namespace ToDo.GraphQL
{
    public class Query
    {
        public Task<List<ToDoItem>> GetItems([Service] ToDoService service) => service.GetAll();

        public Task<ToDoItem> GetItem([Service] ToDoService service, int id) => service.Get(id);
    }
}
