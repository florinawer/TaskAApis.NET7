﻿
namespace Tasks.Infrastructure.Data.Model
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public ToDoTaskStatus Status { get; set; }
    }
}