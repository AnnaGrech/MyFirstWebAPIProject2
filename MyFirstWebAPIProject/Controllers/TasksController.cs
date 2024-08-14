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
    }
}