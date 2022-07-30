using Microsoft.AspNetCore.Http;
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


        // GET: TaskController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Tasks task)
        {
            var x = task;

            _taskRepository.Add(task);
            return View();
        }
    }
}
