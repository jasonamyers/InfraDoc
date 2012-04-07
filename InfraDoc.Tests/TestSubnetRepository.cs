using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Tests
{
    public class TestSubnetRepository : ISubnetRepository
    {
        public IQueryable<Subnet> GetSubnets()
        {
            IList<Subnet> result = new List<Subnet>();

            for (int i = 1; i<=2; i++)
            {
                Subnet s = new Subnet();
                s.SubnetId = i;
                s.SiteId = 1;
                s.Network = "192.168." + i + ".0";
                s.Description = "TestSubnet" + i;
                s.Netmask = "255.255.255.0";
                s.Gateway = "192.168." + i + ".1";
                s.Preference = i;
                result.Add(s);
            }
            return result.AsQueryable<Subnet>();
        }
    }
}
