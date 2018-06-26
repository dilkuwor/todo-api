using System;
namespace ApplicationCore.Exceptions
{
	public class TodoItemNotFoundException: Exception
    {
		public TodoItemNotFoundException(int todoId): base($"No todo item found with id {todoId}"){
			
		}
    }
}
