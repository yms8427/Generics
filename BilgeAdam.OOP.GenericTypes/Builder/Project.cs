using System;

namespace BilgeAdam.OOP.GenericTypes.Builder
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime StartDate { get; set; }
        public int SourceCount { get; set; }
        public decimal Budget { get; set; }
    }
}
