using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3CompanyHierarchy
{
    public class Projects
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private string state;

        public Projects(string projectName, DateTime projectStartDate, string details, string state) 
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return projectName; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Project name cannot be null!");
                }
                projectName = value; 
            }
        }
        public DateTime ProjectStartDate
        {
            get { return projectStartDate; }
            set { projectStartDate = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public string State
        {
            get { return state; }
            set 
            {
                if (value != "open" && value != "close")
                {
                    throw new ArgumentException("Invalid state!");
                }
                state = value; 
            }
        }

        public string CloseProject() 
        {
            return State = "close";
        }
    }
}
