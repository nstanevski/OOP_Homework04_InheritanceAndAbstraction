using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _03_CompanyHierarchy.Persons.Tasks;

namespace _03_CompanyHierarchy.Persons.Interfaces
{
    interface IDeveloper
    {
        List<Project> Projects { get; }
        void AddProject(Project project);
        void DeleteProject(Project project);
    }
}
