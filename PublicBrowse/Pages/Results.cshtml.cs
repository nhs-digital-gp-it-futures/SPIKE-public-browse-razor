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
        public IList<SolutionCapabilities> SolutionCapabilities { get; set; }
        private String CapabilityFileName = "wwwroot/data/capabilites.json";
        private String SolutionFileName = "wwwroot/data/solutions.json";

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
        public void OnGet(IList<CapabilitySelection> capabilitySelections)
        {

            var selectedCapabilityString = this.session.GetString("selectedCapabilities");

            if(selectedCapabilityString != null && selectedCapabilityString != "") {
                capabilitySelections = JsonConvert.DeserializeObject<IList<CapabilitySelection>>(selectedCapabilityString);
            }

            Capabilities = readCapabilities();

            var selectedSet = capabilitySelections.Where((cap) => cap.IsSelected);
            var AllSolutions = readSolutions();

            CapabilitySelectionOptions = Capabilities.Select((cap) => new CapabilitySelection{
                ID = cap.ID,
                IsSelected = selectedSet.Any((sel) => sel.ID == cap.ID)
            }).ToList();

            if(capabilitySelections.Count == 0) {
                SelectedCapabilities = new List<Capability>();
                Solutions = AllSolutions;
            } else {
                SelectedCapabilities = Capabilities.Where(
                    (cap) => selectedSet.Any((sel) => sel.ID == cap.ID)
                ).ToList();

                Solutions = AllSolutions.Where(
                    (sol) => SelectedCapabilities.All(
                        (cap) => sol.CapabilityIDs.Any(
                            (id) => cap.ID == id
                        )
                    )
                ).ToList();
            }
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid) {
                return Page();
            }

            var selectedCapabilities = CapabilitySelectionOptions.Where((cap) => cap.IsSelected).ToList();
            var selectedCapabilitiesString = JsonConvert.SerializeObject(selectedCapabilities);
            this.session.SetString("selectedCapabilities", selectedCapabilitiesString);
            return RedirectToPage("./Results", selectedCapabilitiesString);
        }
    }
}
