using System;
using PP.Library.Models;

namespace PP.Library.Services
{
	public class ProjectService
	{
        private List<Project> projects;
        public List<Project> Projects
        {
            get
            {
                return projects;
            }
        }

        private static ProjectService? instance;
        public static ProjectService Current
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProjectService();
                }

                return instance;
            }
        }

        private ProjectService()
        {
            projects = new List<Project>();
        }

        public void Add(Project project)
        {
            projects.Add(project);
        }
    }
}

