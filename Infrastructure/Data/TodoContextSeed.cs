using ApplicationCore.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class TodoContextSeed
    {
        public static async Task SeedAsync(TodoContext todoContext, ILoggerFactory loggerFactory, int? retry)
        {
            int retryForAvailability = retry.Value;
            try
            {
                if (!todoContext.TodoItems.Any())
                {
                    todoContext.TodoItems.AddRange(GetPreconfiguredTodoItems());
                    await todoContext.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 10)
                {
                    retryForAvailability++;
                    var log = loggerFactory.CreateLogger<TodoContextSeed>();
                    log.LogError(ex.Message);
                    await SeedAsync(todoContext, loggerFactory, retryForAvailability);
                }
            }
        }
        static IEnumerable<TodoItem> GetPreconfiguredTodoItems()
        {
            return new List<TodoItem>()
            {
                new TodoItem(){Title = "Go to nepal"},
                new TodoItem(){Title = "Go to office tomorrow"},
                new TodoItem(){Title = "Call John"},
            };
        }
    }
}
