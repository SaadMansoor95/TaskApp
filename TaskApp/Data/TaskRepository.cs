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
            _dataContext.Tasks.Add(task);
            _dataContext.SaveChanges();
        }
    }
}
