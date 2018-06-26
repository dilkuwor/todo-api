using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Builders
{
    public class TodoItemBuilder
    {
        private TodoItem _todoItem;
        private string _todoTitle => "Go to Siwtzerland";

        public TodoItemBuilder()
        {
            _todoItem = WithDefaultValues();
        }

        public TodoItem Build()
        {
            return _todoItem;
        }

        public TodoItem WithDefaultValues()
        {
            _todoItem = new TodoItem(_todoTitle);
            return _todoItem;
        }

        public TodoItem WithNoTitle()
        {
            _todoItem = new TodoItem();
            return _todoItem;
        }
    }
}
