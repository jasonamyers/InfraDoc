using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data.Interfaces
{
    public interface ISubnetRepository
    {
        IQueryable<Subnet> GetSubnets();
    }
}
