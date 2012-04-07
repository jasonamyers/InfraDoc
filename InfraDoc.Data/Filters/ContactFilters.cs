using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;

namespace InfraDoc.Data.Filters
{
    public static class ContactFilters
    {
        public static IQueryable<Contact> WithSite(this IQueryable<Contact> qry, int siteId)
        {
            return from c in qry
                   where c.SiteId == siteId
                   select c;
        }

        public static IQueryable<Contact> WithID(this IQueryable<Contact> qry, int ID )
        {
            return from c in qry
                   where c.ContactId == ID
                   select c;
        }
    }
}
