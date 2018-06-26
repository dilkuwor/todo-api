using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Services
{
	public class TodoItemService : ITodoItemService
    {
		private readonly IAsyncRepository<TodoItem> _todoItemRepository;
		public TodoItemService(IAsyncRepository<TodoItem> todoItemRepository)
        {
			_todoItemRepository = todoItemRepository;
        }

		public async Task AddItemAsync(string title)
		{
			var item = new TodoItem()
			{
				Title = title
			};
			await _todoItemRepository.AddAsync(item);
		}

		public Task<IEnumerable<TodoItem>> IncompleteItemsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<bool> MarkDoneAsync(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}
