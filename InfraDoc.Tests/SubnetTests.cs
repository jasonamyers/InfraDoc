using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;
using InfraDoc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDoc.Tests
{
    [TestClass]
    public class SubnetTests
    {
        SubnetService subnetService;
        [TestInitialize]
        public void Setup()
        {
            ISubnetRepository rep = new TestSubnetRepository();
            subnetService = new SubnetService(rep);
        }

        [TestMethod]
        public void Subnet_ShouldHave_ID_SiteID_Network_Description_Netmask_Gateway_Preference()
        {
            Subnet s = new Subnet(1, 1, "192.168.4.0","Main LAN","255.255.255.0","192.168.4.200",1);
            
            Assert.AreEqual(1, s.SubnetId);
            Assert.AreEqual(1, s.SiteId);
            Assert.AreEqual("192.168.4.0", s.Network);
            Assert.AreEqual("Main LAN", s.Description);
            Assert.AreEqual("255.255.255.0",s.Netmask);
            Assert.AreEqual("192.168.4.200", s.Gateway);
            Assert.AreEqual(1, s.Preference);
        }

        [TestMethod]
        public void SubnetRepository_Contains_Subnets()
        {
            ISubnetRepository rep = new TestSubnetRepository();
            Assert.IsNotNull(rep.GetSubnets());
        }

        [TestMethod]
        public void Subnet_Has_Site_Filter_for_Subnets()
        {
            ISubnetRepository rep = new TestSubnetRepository();

            IList<Subnet> subnets = rep.GetSubnets()
                .WithSite(1)
                .ToList();
            Assert.IsNotNull(subnets);
        }

        [TestMethod]
        public void SubnetService_Returns_2_Subnets_With_Site_1()
        {
            IList<Subnet> subnets = subnetService.GetSubnetsBySite(1);
            Assert.AreEqual(2, subnets.Count);
        }
    }
}
