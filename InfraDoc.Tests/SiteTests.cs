using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using InfraDoc.Data;
using InfraDoc.Data.Interfaces;
using InfraDoc.Data.Filters;
using InfraDoc.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InfraDoc.Tests
{
    [TestClass]
    public class SiteTests
    {
        SiteService siteService;
        [TestInitialize]
        public void Setup()
        {
            ISiteRepository rep = new TestSiteRepository();
            siteService = new SiteService(rep);
        }

        [TestMethod]
        public void Site_ShouldHave_Name_Address_Description_Priority()
        {
            Site s = new Site(1, "TestName", "1238 Murfreesboro Road, Suite 500, Nashville, TN 37217", "HomeOffice", 1);
            
            Assert.AreEqual(1, s.SiteId);
            Assert.AreEqual("TestName", s.Name);
            Assert.AreEqual("1238 Murfreesboro Road, Suite 500, Nashville, TN 37217", s.Address);
            Assert.AreEqual("HomeOffice",s.Description);
            Assert.AreEqual(1,s.Priority);
        }

        [TestMethod]
        public void SiteRepository_Repository_Contains_Sites()
        {
            ISiteRepository rep = new TestSiteRepository();
            Assert.IsNotNull(rep.GetSites());
        }

        [TestMethod]
        public void SiteService_Can_Get_Sites_From_Service()
        {
            IList<Site> sites = siteService.GetSites();
            Assert.IsTrue(sites.Count > 0);

        }

        [TestMethod]
        public void SiteRepository_Returns_Single_Site_When_Filtered_ByID_1()
        {
            ISiteRepository rep = new TestSiteRepository();

            IList<Site> sites = rep.GetSites().WithID(1).ToList();

            Assert.AreEqual(1,sites.Count);
        }

        [TestMethod]
        public void SiteService_Returns_Single_Site_With_SiteID_1()
        {
            Site s = siteService.GetSiteByID(1);
            Assert.IsNotNull(s);
        }

        


    }
}
