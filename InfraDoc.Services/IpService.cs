using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Services
{
    public class IpService
    {
        private IIpRepository _repository = null;

        public IpService(IIpRepository repository)
        {
            _repository = repository;
            if(_repository ==null)
                throw new Exception("Repository cannot be null");
        }

        public IList<Ip> GetIps()
        {
            return _repository.GetIps().ToList();
        }

        public IList<Ip> GetIpsBySubnet(int subnetID)
        {
            return _repository.GetIps().WithSubnet(subnetID).ToList();
        }

        public Ip GetIpByID(int ID)
        {
            return _repository.GetIps().WithID(ID).Single();
        }
    }
}
