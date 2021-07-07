using System;

namespace API.Entities
{
    public class Entry
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }
        public bool IsExpense { get; set; }
        
    }
}