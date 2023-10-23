using MediatR;

namespace TodoList.BusinessLogic.Queries.GetAllTasks
{
    public class GetAllTasksQuery : IRequest<IEnumerable<GetAllTasksResponse>>
    {
    }
}
