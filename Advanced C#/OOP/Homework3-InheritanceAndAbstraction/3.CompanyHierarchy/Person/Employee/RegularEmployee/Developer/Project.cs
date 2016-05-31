using System;
using System.Collections.ObjectModel;

namespace _3.CompanyHierarchy
{
    class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private bool isOpen;

        public Project(string projectName, DateTime projectStartDate, string details, bool isOpen)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.IsOpen = isOpen;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "Project name cannot be empty !");
                }
                this.projectName = value;
            }
        }
        public DateTime ProjectStartDate { get; set; }
        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project details cannot be empty !");
                }
                this.details = value;
            }
        }

        public bool IsOpen { get; set; }

        public void CloseProject(Project project)
        {
            this.IsOpen = false;
            Console.WriteLine("The project is closed !");
        }

        public override string ToString()
        {
            return String.Format("Project name: {0}\nStarted on: {1}\nIs the project open: {2}\nDetails: {3}",
             this.ProjectName, this.ProjectStartDate.ToString(), this.IsOpen.ToString(), this.Details);
        }

    }
}
