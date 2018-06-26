using ApplicationCore.Entities;
using ApplicationCore.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace UnitTest.Specification
{
    public class TodoItemFilterSpecificationFilter
    {
        [Theory]
        [InlineData(false,2)]
        [InlineData(true,1)]
        public void MatchesExpectedNumberOfItems(bool isDone, int expectedCount)
        {
            var spec = new TodoItemFilterSpecification(isDone);
            var result = GetTestItemCollection().AsQueryable()
                .Where(spec.Criteria);
            Assert.Equal(expectedCount, result.Count());
        }

        public List<TodoItem> GetTestItemCollection()
        {
            return new List<TodoItem>()
            {
                new TodoItem(){Id = 1, Title = "Go to office"},
                new TodoItem(){Id = 2, Title = "Go to office"},
                new TodoItem(){Id = 3, Title = "Go to Canada",IsDone = true}
                
            };
        }
    }
}
