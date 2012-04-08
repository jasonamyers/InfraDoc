using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data
{
    public class Ip
    {
        public int IpId { get; set; }
        public int SubnetId { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public string Url { get; set; }
        public Subnet Subnet { get; set; }

        public Ip()
        {
            
        }

        public Ip(int subnetID, string address, string name, string purpose, string url)
        {
            this.SubnetId = subnetID;
            this.Address = address;
            this.Name = name;
            this.Purpose = purpose;
            this.Url = url;
        }
    }
}
