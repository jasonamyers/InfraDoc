using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data
{
    public class Subnet
    {
        public int SubnetId { get; set; }
        public int SiteId { get; set; }
        public string Network { get; set; }
        public string Description { get; set; }
        public string Netmask { get; set; }
        public string Gateway { get; set; }
        public int Preference { get; set; }
        public Site Site { get; set; }
        public IList<Ip> Ips { get; set; }

        public Subnet()
        {
            
        }

        public Subnet(int subnetID, int siteID, string network, string description, string netmask, string gateway, int preference)
        {
            this.SubnetId = subnetID;
            this.SiteId = siteID;
            this.Network = network;
            this.Description = description;
            this.Netmask = netmask;
            this.Gateway = gateway;
            this.Preference = preference;
        }
    }
}
