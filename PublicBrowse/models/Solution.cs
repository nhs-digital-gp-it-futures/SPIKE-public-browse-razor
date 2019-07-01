using System.Collections.Generic;

namespace PublicBrowse.Models
{
    public class Solution
    {
        public int ID { get; set; }
        public bool IsFoundation { get; set; }
        public string Name { get; set; }
        public string Organisation { get; set; }
        public string Description { get; set; }
        public IList<int> CapabilityIDs { get; set; }
        public IList<string> Features { get; set; }
        public string Framework { get; set; }
        public string ListPrice { get; set; }
        public IList<Service> AdditionalServices { get; set; }
        public IList<Service> AssociatedServices { get; set; }
    }
}