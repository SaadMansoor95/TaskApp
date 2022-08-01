using System.Collections.Generic;
using TaskApp.Models;

namespace TaskApp.Data
{
    public interface ITaskRepository
    {
        List<Tasks> GetAllTask();
        void Add(Tasks task);
        void Remove(int id);
    }
}
