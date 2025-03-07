namespace ASP.NET_TODO_list.Controllers
{
    using ASP.NET_TODO_list.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System;

    public class ToDoController : Controller
    {
        private static List<ToDoItem> _toDoList = new List<ToDoItem>();
        private static int _nextId = 1;

        public IActionResult Index()
        {
            return View(_toDoList);
        }

        [HttpPost]
        public IActionResult Create(string title, string priority, DateTime dueTime)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                _toDoList.Add(new ToDoItem { Id = _nextId++, Title = title, IsCompleted = false, Priority = priority, DueTime = dueTime });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var item = _toDoList.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(ToDoItem updatedItem)
        {
            var existingItem = _toDoList.FirstOrDefault(t => t.Id == updatedItem.Id);
            if (existingItem != null)
            {
                existingItem.Title = updatedItem.Title;
                existingItem.Priority = updatedItem.Priority;
                existingItem.DueTime = updatedItem.DueTime;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var item = _toDoList.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                _toDoList.Remove(item);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult ToggleComplete(int id)
        {
            var item = _toDoList.FirstOrDefault(t => t.Id == id);
            if (item != null)
            {
                item.IsCompleted = !item.IsCompleted;
            }
            return RedirectToAction("Index");
        }
    }

}
