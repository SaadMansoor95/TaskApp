using TaskApp.Models;

namespace TaskApp.Data
{
    public interface ITaskRepository
    {
        void Add(Tasks task);
        void Remove(int id);
    }
}
