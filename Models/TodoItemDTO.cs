using System;
namespace TodoApi.Models
{
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
