using System.Linq;
using TaskApp.Models;

namespace TaskApp.Data
{
    public class TaskRepository:ITaskRepository
    {
        private readonly DataContext _dataContext;

        public TaskRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Tasks task)
        {
            _dataContext.Add(task);
            _dataContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var task = _dataContext.Tasks.FirstOrDefault(t => t.TaskId == id);

            if (task!=null)
            {
                _dataContext.Tasks.Remove(task);
            }

            _dataContext.SaveChanges();
        }
    }
}
