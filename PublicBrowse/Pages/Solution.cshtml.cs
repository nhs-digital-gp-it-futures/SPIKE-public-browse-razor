using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PublicBrowse.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace PublicBrowse.Pages
{
    public class SolutionModel : PageModel
    {
        private readonly ISession session;
        private String SolutionFileName = "wwwroot/data/solutions.json";
        private IList<Solution> Solutions;
        public Solution SelectedSolution;
        public int SolutionID;

        public SolutionModel(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }

        private IList<Solution> readSolutions() {
            String jsonText = System.IO.File.ReadAllText(SolutionFileName);
            return JsonConvert.DeserializeObject<IList<Solution>>(jsonText);
        }

        public void OnGet(int solutionID)
        {
            SolutionID = solutionID;
            Solutions = readSolutions();
            SelectedSolution = Solutions.Where((sol) => sol.ID == SolutionID).First();
        }
    }
}
