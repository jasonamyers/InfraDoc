using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.DataAccess;

namespace InfraDoc.Tests
{
    public class TestSiteRepository : ISiteRepository
    {
        public IQueryable<Site> GetSites()
        {
            IList<Site> result = new List<Site>();

            for (int i = 1; i<=2; i++)
            {
                Site s = new Site();
                s.SiteId = i;
                s.Address = "1283" + i + "Murfreesboro Road, Nashville, TN 37217";
                s.Description = "Site" + i;
                s.Name = i + "Site";
                s.Priority = i;
                result.Add(s);
            }
 
            return result.AsQueryable<Site>();
        }
    }
}
