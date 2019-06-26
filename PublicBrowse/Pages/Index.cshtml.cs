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
    public class IndexModel : PageModel
    {

        private readonly ISession session;
        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            this.session = httpContextAccessor.HttpContext.Session;
        }
        public IList<Capability> Capabilities { get; set;}

        [BindProperty]
        public IList<CapabilitySelection> SelectableCapabilities { get; set; }
        private String CapabilityFileName = "wwwroot/data/capabilites.json";

        private IList<Capability> readCapabilities() {
            String jsonText = System.IO.File.ReadAllText(CapabilityFileName);
            return JsonConvert.DeserializeObject<IList<Capability>>(jsonText);
        }

        public void OnGet()
        {
            Capabilities = readCapabilities();
            SelectableCapabilities = Capabilities.Select(
                (cap) => new CapabilitySelection{ ID = cap.ID, IsSelected = false }
            ).ToList();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid) {
                return Page();
            }

            var selectedCapabilities = SelectableCapabilities.Where((cap) => cap.IsSelected).ToList();
            var selectedCapabilitiesString = JsonConvert.SerializeObject(selectedCapabilities);
            this.session.SetString("selectedCapabilities", selectedCapabilitiesString);
            return RedirectToPage("./Results", selectedCapabilitiesString);
        }
    }
}
