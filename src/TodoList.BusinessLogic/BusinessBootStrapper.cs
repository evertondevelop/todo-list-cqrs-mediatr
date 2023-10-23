using Microsoft.Extensions.DependencyInjection;

namespace TodoList.BusinessLogic
{
    public static class BusinessBootStrapper
    {
        public static void AddBusinessDependecies(this IServiceCollection service)
        {
            service.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(BusinessBootStrapper).Assembly);
            });
        }
    }
}
