using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPIProject.Models;

namespace MyFirstWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private static List<Task1> _tasks = new List<Task1>
        {
             new Task1 { Id = 1, Date = new DateOnly(2024, 08, 14), Title = "Волейбол", Description = "Тренировка для новвичков в 18.00" },
            new Task1 { Id = 2, Date = new DateOnly(2024, 08, 15), Title = "ИСБ", Description = "Тренировка в зале в 18.30" },
            new Task1 { Id = 3, Date = new DateOnly(2024, 08, 16), Title = "Настолки", Description = "Игры в Мипле в 20.00" },
            // Add more tasks
        };

        // GET: api/tasks
        [HttpGet]
        public ActionResult<IEnumerable<Task1>> GetTasks()
        {
            return _tasks;
        }

        // GET: api/tasks/2
        [HttpGet("{id}")]
        public ActionResult<Task1> GetTasks(int id)
        {
            var Task1 = _tasks.FirstOrDefault(p => p.Id == id);
            if (Task1 == null)
            {
                return NotFound();
            }
            return Task1;
        }

        // POST: api/tasks
        [HttpPost]
        public ActionResult<Task1> PostTasks(Task1 exersice)
        {
            foreach (var task in _tasks)
            {
                if (task.Id == exersice.Id)
                {
                    return BadRequest("You are rukozhopuii progremmist");
                }
            }


            _tasks.Add(exersice);
        
            return CreatedAtAction(nameof(GetTasks), new { id = exersice.Id }, exersice);


        }

        // DELETE: api/tasks
        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var exersice = _tasks.FirstOrDefault(p => p.Id == id);
            if (exersice == null)
            {
                return NotFound();
            }
            _tasks.Remove(exersice);
            // In a real application, here you would delete the product from the database
            return NoContent();
        }

        // PUT: api/tasks
        [HttpPut("{id}")]
        public IActionResult PutTask(int id, Task1 exersice)
        {
            if (id != exersice.Id)
            {
                return BadRequest();
            }
            var existingTask = _tasks.FirstOrDefault(p => p.Id == id);
            if (existingTask == null)
            {
                return NotFound();
            }
            existingTask.Date = exersice.Date;
            existingTask.Title = exersice.Title;
            existingTask.Description = exersice.Description;
            // In a real application, here you would update the product in the database
            return NoContent();
        }
    }

 
}