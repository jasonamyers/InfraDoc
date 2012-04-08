using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data.Filters
{
    public static class SubnetFilters
    {
        public static IQueryable<Subnet> WithSite(this IQueryable<Subnet> qry, int siteID )
        {
            return from s in qry
                   where s.SiteId == siteID
                   select s;

        }

        public static IQueryable<Subnet> WithID(this IQueryable<Subnet> qry, int ID )
        {
            return from s in qry
                   where s.SubnetId == ID
                   select s;
        }
    }
}
