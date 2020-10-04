using System;

namespace BilgeAdam.OOP.GenericTypes.Builder
{
    public class ProjectBuilder
    {
        private readonly Project project;
        public ProjectBuilder()
        {
            project = new Project
            {
                Id = 1,
                StartDate = DateTime.Now,
                SourceCount = 1
            };
        }

        public Project Build()
        {
            return project;
        }

        public ProjectBuilder WithName(string name)
        {
            project.Name = name;
            return this;
        }

        public ProjectBuilder WithSourceCount(int count)
        {
            project.SourceCount = count;
            return this;
        }

        public ProjectBuilder WithStartDate(DateTime startDate)
        {
            project.StartDate = startDate;
            return this;
        }

        public ProjectBuilder WithDueDate(DateTime dueDate)
        {
            if (dueDate < project.StartDate)
            {
                throw new ArgumentException("Proje tarihleri uyumsuz");
            }
            project.DueDate = dueDate;
            return this;
        }

        public ProjectBuilder WithBudget(decimal budget)
        {
            if (budget < 0)
            {
                throw new ArgumentException("Bütçe verilebiilir bir sınırda değil");
            }
            project.Budget = budget;
            return this;
        }
    }
}
