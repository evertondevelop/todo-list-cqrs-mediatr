using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Data.Context;

namespace TodoList.Data
{
    public static class InfraBootStrapper
    {
        public static void AddInfraDependecies(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<TodoListContext>(options => options.UseSqlServer(connectionString));
        }

        public static void RunMigrations(this IServiceProvider services)
        {
            using var scope = services.CreateScope();

            var dbContext = scope.ServiceProvider.GetRequiredService<TodoListContext>();
            if (dbContext.Database.GetPendingMigrations().Any())
                dbContext.Database.Migrate();
        }
    }
}
