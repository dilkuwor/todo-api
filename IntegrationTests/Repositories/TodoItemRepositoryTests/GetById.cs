using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.Builders;
using Xunit;
using Xunit.Abstractions;


namespace IntegrationTests.Repositories.TodoItemRepositoryTests
{
    public class GetById
    {
        private readonly TodoContext _todoContext;
        private readonly TodoItemRepository _todoItemRepository;
        private readonly ITestOutputHelper _output;
        private TodoItemBuilder TodoItemBuilder { get; } = new TodoItemBuilder();

        public GetById(ITestOutputHelper output)
        {
            _output = output;
            var dbOptions = new DbContextOptionsBuilder<TodoContext>().Options;
            _todoContext = new TodoContext(dbOptions);
            _todoItemRepository = new TodoItemRepository(_todoContext);
        }
        [Fact]
        public void GetExistingTodoItems()
        {
            var existingItem = TodoItemBuilder.WithDefaultValues();
            _todoContext.TodoItems.Add(existingItem);
            _todoContext.SaveChanges();
            var itemId = existingItem.Id;
            _output.WriteLine($"Todo name {existingItem.Title}");

            var todoItemFromRepo = _todoItemRepository.GetById(itemId);
            Assert.Equal(existingItem.Title, todoItemFromRepo.Title);

        }
    }
}
