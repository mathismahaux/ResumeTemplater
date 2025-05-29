using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
	public class IndexModel : PageModel
	{
    public string FullName { get; set; }
    public string LinkedInUsername { get; set; }
    public int YearsOfExperience { get; set; }
    public List<string> Languages { get; set; }	

    public void OnGet() 
    {
      FullName = "Mathis Mahaux";      
      LinkedInUsername = "Mathis Mahaux";
      YearsOfExperience = 1;
      Languages = new List<string>();
      Languages.Add("French");
      Languages.Add("Dutch");
      Languages.Add("English");
    }
  }
}
