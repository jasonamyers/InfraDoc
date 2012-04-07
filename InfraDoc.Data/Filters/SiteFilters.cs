using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data.Filters
{
    public static class SiteFilters
    {
        public static IQueryable<Site> WithID(this IQueryable<Site> qry, int ID )
        {
            return from s in qry 
                   where s.SiteId == ID 
                   select s;
        }
    }
}
