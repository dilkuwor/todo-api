using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
	public interface ITodoItemService
    {
		Task<IEnumerable<TodoItem>> IncompleteItemsAsync();
		Task AddItemAsync(string title);
        Task<bool> MarkDoneAsync(int id);
    }
}
