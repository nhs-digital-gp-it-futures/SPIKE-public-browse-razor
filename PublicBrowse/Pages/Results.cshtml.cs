using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PublicBrowse.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace PublicBrowse.Pages
{
    public class ResultsModel : PageModel
    {
        private readonly ISession session;
        public ResultsModel(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }
        public IList<Capability> Capabilities { get; set;}
        public IList<Capability> SelectedCapabilities { get; set;}
        [BindProperty]
        public IList<CapabilitySelection> CapabilitySelectionOptions { get; set; }
        public IList<Solution> Solutions { get; set; }
        public IList<SolutionResult> SolutionResults { get; set; }
        public IList<SolutionCapabilities> SolutionCapabilities { get; set; }
        private String CapabilityFileName = "wwwroot/data/capabilites.json";
        private String SolutionFileName = "wwwroot/data/solutions.json";

        [BindProperty]
        public FoundationFilters SolutionFilters { get; set; } = new FoundationFilters {
            ShowFoundation = true,
            ShowNonFoundation = true,
            FoundationOnly = false
        };


        private IList<Capability> readCapabilities() {
            String jsonText = System.IO.File.ReadAllText(CapabilityFileName);
            return JsonConvert.DeserializeObject<IList<Capability>>(jsonText);
        }

        private IList<Solution> readSolutions() {
            String jsonText = System.IO.File.ReadAllText(SolutionFileName);
            return JsonConvert.DeserializeObject<IList<Solution>>(jsonText);
        }

        private IList<Capability> sortCapabilitiesByTitleAsc(List<Capability> capabilites) {
            IEnumerable<Capability> sortedEnum = capabilites.OrderBy(cap=>cap.Title);
            return sortedEnum.ToList();
        }
        private IList<Solution> sortSolutionByNameAsc(List<Solution> solutions) {
            IEnumerable<Solution> sortedEnum = solutions.OrderBy(sol=>sol.Name);
            return sortedEnum.ToList();
        }
        public void OnGet(bool onlyFoundation, bool allSolutions)
        {
            if(allSolutions) {
                this.session.Remove("selectedCapabilities");
                this.session.Remove("solutionFilters");
            }

            SolutionFilters.FoundationOnly = onlyFoundation;

            IList<CapabilitySelection> capabilitySelections = new List<CapabilitySelection>();

            // Capability Selection Data
            var selectedCapabilityString = this.session.GetString("selectedCapabilities");
            if(selectedCapabilityString != null && selectedCapabilityString != "") {
                capabilitySelections = JsonConvert.DeserializeObject<IList<CapabilitySelection>>(selectedCapabilityString);
            }

            // Solution Selection Data
            var solutionFiltersString = this.session.GetString("solutionFilters");
            if(solutionFiltersString != null && solutionFiltersString != "") {
                SolutionFilters = JsonConvert.DeserializeObject<FoundationFilters>(solutionFiltersString);
            }

            // Read All Capability List
            Capabilities = readCapabilities();

            // Filter Only Selected Capabilitys
            var selectedSet = capabilitySelections.Where((cap) => cap.IsSelected);
            var AllSolutions = readSolutions();

            // Build Capability Selection Options
            CapabilitySelectionOptions = Capabilities.Select((cap) => new CapabilitySelection{
                ID = cap.ID,
                IsSelected = selectedSet.Any((sel) => sel.ID == cap.ID)
            }).ToList();

            // initialise selected capabilities and visible solutions
            SelectedCapabilities = new List<Capability>();
            Solutions = AllSolutions;

            // Filter Solutions by selected capabilities.
            if(capabilitySelections.Count != 0) {
                SelectedCapabilities = Capabilities.Where(
                    (cap) => selectedSet.Any((sel) => sel.ID == cap.ID)
                ).ToList();

                SolutionResults = AllSolutions.Select(
                    (sol) => new SolutionResult {
                        solution = sol,
                        matchingCapabilities = SelectedCapabilities.Where(
                            // capabilities that are in the solution, and are selected
                            (cap) => sol.CapabilityIDs.Any((id) => id == cap.ID)
                        ).ToList(),
                        otherCapabilities = Capabilities.Where(
                            // capabilities where it is in the solution, but not selected
                            (cap) => sol.CapabilityIDs.Any(id => id == cap.ID) && !SelectedCapabilities.Any(sel => sel.ID == cap.ID)
                        ).ToList()
                    }
                )
                .Where((sol) => sol.matchingCapabilities.Count > 0)
                .OrderByDescending((solRes) => solRes.matchingCapabilities.Count)
                .ToList();
            } else {
                SolutionResults = AllSolutions.Select(
                    (sol) => new SolutionResult{
                        solution = sol,
                        matchingCapabilities = new List<Capability>(),
                        otherCapabilities = Capabilities.Where(
                            (cap) => sol.CapabilityIDs.Any(id => id == cap.ID)
                        ).ToList()
                    }
                ).ToList();
            }

            // filter-out non-foundation solutions
            if(SolutionFilters.FoundationOnly) {
                SolutionResults = SolutionResults.Where((sol) => sol.solution.IsFoundation).ToList();
            }
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid) {
                return Page();
            }

            this.session.Remove("selectedCapabilities");
            this.session.Remove("solutionFilters");

            var selectedCapabilities = CapabilitySelectionOptions.Where((cap) => cap.IsSelected).ToList();
            var selectedCapabilitiesString = JsonConvert.SerializeObject(selectedCapabilities);
            this.session.SetString("selectedCapabilities", selectedCapabilitiesString);

            var solutionFiltersString = JsonConvert.SerializeObject(SolutionFilters);
            this.session.SetString("solutionFilters", solutionFiltersString);

            return RedirectToPage("./Results", selectedCapabilitiesString);
        }
    }
}
