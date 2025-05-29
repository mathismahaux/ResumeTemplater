using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeTemplater.Models;

namespace ResumeTemplater.Pages
{
	public class ProjectsModel : PageModel
	{
  
		public List<Project> Projects { get; set; }
    public string GithubUsername { get; set; }
    GithubUsername = "mathismahaux";
    
		public void OnGet()
        {
            Projects = new List<Project> {
                new Project()
                {
                    Title = "GamerHistory",
                    Description = "A Full Stack, Dockerized app for managing your gaming sessions history. Built with ASP.NET Core and Angular.",
                    Year = 2025
                },
                new Project()
                {
                    Title = "DiningReview",
                    Description = "An API for leaving reviews on restaurants. Built Spring Boot.",
                    Year = 2025
                },
                new Project()
                {
                    Title = "Netflix",
                    Description = "A program that analyses data coming from Netflix. Built with Python, Pandas and NumPy.",
                    Year = 2025
                }
            };
        }
	}
}
