using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data.DataAccess
{
    public interface ISiteRepository
    {
        IQueryable<Site> GetSites();
    }
}
