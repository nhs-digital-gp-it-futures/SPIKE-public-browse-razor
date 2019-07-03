using System.Collections.Generic;

namespace PublicBrowse.Models
{
    public class SolutionResult
    {
        public Solution solution { get; set; }
        public IList<Capability> matchingCapabilities { get; set; }
        public IList<Capability> otherCapabilities { get; set; }
    }
}