using MediatR;
using Microsoft.AspNetCore.Mvc;
using TodoList.BusinessLogic.Queries.GetAllTasks;

namespace TodoList.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private ISender _mediator;

        public TasksController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetTodoList([FromQuery] GetAllTasksQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}