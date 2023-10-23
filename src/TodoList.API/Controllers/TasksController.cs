using Microsoft.AspNetCore.Mvc;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        public TasksController()
        {
        }

        [HttpGet()]
        public IActionResult GetTodoList()
        {
            return Ok();
        }
    }
}