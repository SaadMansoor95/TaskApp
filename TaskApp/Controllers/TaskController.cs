using Microsoft.AspNetCore.Mvc;
using TaskApp.Data;
using TaskApp.Models;

namespace TaskApp.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tasks task)
        {
            _taskRepository.Add(task);

            return View();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            _taskRepository.Remove(id);

            return Ok();
        }

        public ActionResult TasksList()
        {
            var list = _taskRepository.GetAllTask();

            return PartialView("_TaskList", list);
        }
    }
}