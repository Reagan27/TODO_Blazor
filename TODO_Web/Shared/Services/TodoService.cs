using System;
using System.Collections.Generic;
using System.Linq;
using TODO_Web.Models;

namespace TODO_Web.Services
{
    public class TodoService
    {
        private List<TodoItem> todoItems = new List<TodoItem>
        {
            new TodoItem { Id = 1, Title = "Learn Blazor", IsDone = false },
            new TodoItem { Id = 2, Title = "Build a Blazor app", IsDone = false }
        };

        public List<TodoItem> GetTodoItems()
        {
            return todoItems;
        }
    }
}
