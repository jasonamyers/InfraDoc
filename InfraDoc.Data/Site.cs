using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data
{
    public class Site
    {
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public IList<Contact> Contacts { get; set; }
        public IList<Subnet> Subnets { get; set; }

        public Site()
        {

        }

        public Site(int siteID, string name, string address, string description, int priority)
        {
            this.SiteId = siteID;
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Priority = priority;
        }
    }

}
