using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class TodoItemRepository : EfRepository<TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(TodoContext dbContext) : base(dbContext) { }
    }
}
