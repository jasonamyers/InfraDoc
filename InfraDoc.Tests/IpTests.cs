using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Interfaces;
using InfraDoc.Data.Filters;
using InfraDoc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDoc.Tests
{
    [TestClass]
    public class IpTests
    {
        IpService ipService;
        [TestInitialize]
        public void Setup()
        {
            IIpRepository rep = new TestIpRepository();
            ipService = new IpService(rep);
        }

        [TestMethod]
        public void Ip_ShouldHave_SubnetID_Address_Name_Purpose_Url()
        {
            Ip i = new Ip(1,"192.168.4.3","pdcdcm","Kronos Server", "http://opsview");

            Assert.AreEqual(1,i.SubnetId);
            Assert.AreEqual("192.168.4.3", i.Address);
            Assert.AreEqual("pdcdcm",i.Name);
            Assert.AreEqual("Kronos Server", i.Purpose);
            Assert.AreEqual("http://opsview", i.Url);
        }

        [TestMethod]
        public void IpRepository_Contains_Ips()
        {
            IIpRepository rep = new TestIpRepository();
            Assert.IsNotNull(rep.GetIps());
        }

        [TestMethod]
        public void IpService_Contains_Ips()
        {
            IList<Ip> ips = ipService.GetIps();
            Assert.IsNotNull(ips);
        }

        [TestMethod]
        public void IpRepository_Has_Subnet_Filter_For_Ips()
        {
            IIpRepository rep = new TestIpRepository();

            IList<Ip> ips = rep.GetIps().WithSubnet(1).ToList();
            Assert.IsNotNull(ips);
        }

        [TestMethod]
        public void IpRepository_SubnetFilter_Returns_10_Ips_With_Subnet_1()
        {
            IIpRepository rep = new TestIpRepository();
            IList<Ip> ips = rep.GetIps().WithSubnet(1).ToList();
            Assert.AreEqual(10, ips.Count);
        }

        [TestMethod]
        public void IpService_Returns_10_Ips_With_Subnet_1()
        {
            IList<Ip> ips = ipService.GetIpsBySubnet(1);
            Assert.AreEqual(10,ips.Count);
        }

        [TestMethod]
        public void IpRepository_Returns_Single_Ip_When_Filtered_byID_1()
        {
            IIpRepository rep = new TestIpRepository();
            IList<Ip> ips = rep.GetIps().WithID(1).ToList();
            Assert.AreEqual(1,ips.Count);
        }

        [TestMethod]
        public void IpService_Returns_Single_Ip_When_Filtered_byID_1()
        {
            Ip i = ipService.GetIpByID(1);
            Assert.IsNotNull(i);
        }

    }
}
