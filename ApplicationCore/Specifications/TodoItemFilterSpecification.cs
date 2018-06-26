using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Specifications
{
    public class TodoItemFilterSpecification : BaseSpecification<TodoItem>
    {
        public TodoItemFilterSpecification(bool isDone):
            base(i=>i.IsDone == isDone)
        {

        }
    }
}
