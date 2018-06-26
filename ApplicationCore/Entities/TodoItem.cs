using System;
using System.Collections.Generic;
namespace ApplicationCore.Entities
{
	public class TodoItem : BaseEntity
    {
        public TodoItem() { }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public TodoItem(string title)
        {
            Title = title;
        }
    }
}
