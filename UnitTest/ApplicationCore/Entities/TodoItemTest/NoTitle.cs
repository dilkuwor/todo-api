using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.Builders;
using Xunit;

namespace UnitTest.ApplicationCore.Entities.TodoItemTest
{
    public class NoTitle
    {
        [Fact]
        public void IsEmptyTitle()
        {
            var todoItem = new TodoItemBuilder().WithNoTitle();
            Assert.True(string.IsNullOrEmpty(todoItem.Title));
        }
    }
}
