using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;

namespace ApplicationCore.Services
{
	public class TodoItemService : ITodoItemService
    {
		private readonly IAsyncRepository<TodoItem> _todoItemRepository;
		public TodoItemService(IAsyncRepository<TodoItem> todoItemRepository)
        {
			_todoItemRepository = todoItemRepository;
        }

        /// <summary>
        /// add new todo item
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
		public async Task AddItemAsync(string title)
		{
			var item = new TodoItem()
			{
				Title = title
			};
			await _todoItemRepository.AddAsync(item);
		}

        /// <summary>
        /// Returns incomplete todo items
        /// </summary>
        /// <returns></returns>
		public async Task<IEnumerable<TodoItem>> IncompleteItemsAsync()
		{
            var isDone = false;
            var todoItemSpec = new TodoItemFilterSpecification(isDone);
            var query = await _todoItemRepository.ListAsync(todoItemSpec);
            return query;
		}

        /// <summary>
        /// mark the selected todo item as completed
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
		public async Task<bool> MarkDoneAsync(int id)
		{
            var todoItem = await _todoItemRepository.GetByIdAsync(id);
            todoItem.IsDone = true;
            await _todoItemRepository.UpdateAsync(todoItem);
            return true;
		}
	}
}
