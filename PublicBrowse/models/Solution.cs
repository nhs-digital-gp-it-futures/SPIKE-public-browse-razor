using System.Collections.Generic;

namespace PublicBrowse.Models
{
    public class Solution
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<int> CapabilityIDs { get; set; }
    }
}