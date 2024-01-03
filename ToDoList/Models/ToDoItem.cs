using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models;

internal class ToDoItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
