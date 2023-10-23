using MediatR;

namespace TodoList.BusinessLogic.Queries.GetAllTasks
{
    public class GetAllTasksHandler : IRequestHandler<GetAllTasksQuery, IEnumerable<GetAllTasksResponse>>
    {
        public async Task<IEnumerable<GetAllTasksResponse>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetAllTasksResponse[]
            {
                new GetAllTasksResponse()
                {
                    Id = Guid.NewGuid()
                }
            });
        }
    }
}
