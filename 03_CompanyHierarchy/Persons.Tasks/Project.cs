using System;


//A project holds project name, project start date, details and a state (open or closed). 
//A project can be closed through the method CloseProject().
namespace _03_CompanyHierarchy.Persons.Tasks
{
    public enum PrjState{Open,Closed};

    public class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private PrjState projectState;

        public Project(string projectName, DateTime projectStartDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.projectState = PrjState.Open;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Project name cannot be empty");
                this.projectName = value;

            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                if (value.GetType().Name != "DateTime")
                    throw new ArgumentException("Project date must be DateTime object");
                if (value < DateTime.Now)
                    throw new ArgumentException("Project date cannot be past");
                this.projectStartDate = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Project details cannot be empty");
                this.details = value;

            }
        }

        public PrjState ProjectState
        {
            get
            {
                return this.projectState;
            }
        }

        public void CloseProject()
        {
            this.projectState = PrjState.Closed;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} Start date: {1} Details: {2} State: {3}",
                this.ProjectName, this.ProjectStartDate, this.Details, this.ProjectState);
        }
    }
}
