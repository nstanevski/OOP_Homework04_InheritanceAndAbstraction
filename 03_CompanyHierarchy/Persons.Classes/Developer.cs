using System;
using System.Text;
using System.Collections.Generic;

using _03_CompanyHierarchy.Persons.Tasks;
using _03_CompanyHierarchy.Persons.Interfaces;

namespace _03_CompanyHierarchy.Persons.Classes
{
    public class Developer:RegularEmployee, IDeveloper
    {
        private List<Project> projects;
        public Developer(string id, string fName, string lName,
            decimal salary, Department department, List<Project> projects)
            :base(id, fName, lName, salary, department)
        {
            if (projects == null)
                projects = new List<Project>();
            this.projects = projects;
        }

        public List<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }

        public void AddProject(Project project)
        {
            if (!this.Projects.Contains(project))
                Projects.Add(project);
        }

        public void DeleteProject(Project project)
        {
            if (this.Projects.Contains(project))
                Projects.Remove(project);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            if (this.Projects.Count > 0)
            {
                sb.Append("\nProjects list:\n");
                string projectsStr = string.Join("\n", this.Projects);
                sb.Append(projectsStr);
            }
            return sb.ToString();
        }

        

            
    }
}
