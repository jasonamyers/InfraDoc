using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using InfraDoc.Data;
using InfraDoc.Data.DataAccess;
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
        public void SiteRepository_Repository_IsNotNull()
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


    }
}
