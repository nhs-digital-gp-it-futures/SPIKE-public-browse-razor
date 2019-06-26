using System.Collections.Generic;

namespace PublicBrowse.Models
{
    public class SolutionCapabilities
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Capability> Capabilities { get; set; }
    }
}