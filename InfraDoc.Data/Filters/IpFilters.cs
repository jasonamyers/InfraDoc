using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data.Filters
{
    public static class IpFilters
    {
        public static IQueryable<Ip> WithSubnet(this IQueryable<Ip> qry, int subnetID )
        {
            return from i in qry
                   where i.SubnetId == subnetID
                   select i;
        }

        public static IQueryable<Ip> WithID(this IQueryable<Ip> qry, int ipID )
        {
            return from i in qry
                   where i.IpId == ipID
                   select i;
        }
    }

}
