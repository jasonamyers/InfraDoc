using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Services
{
    public class SubnetService
    {
        ISubnetRepository _repository = null;

        public SubnetService(ISubnetRepository repository)
        {
            _repository = repository;
            if(_repository == null)
                throw new Exception("Repository cannot be null");
        }

        public IList<Subnet> GetSubnetsBySite(int siteID)
        {
            return _repository.GetSubnets().WithSite(siteID).ToList();
        }
    }
}
