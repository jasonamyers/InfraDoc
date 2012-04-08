using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Tests
{
    public class TestIpRepository : IIpRepository
{
        public IQueryable<Ip> GetIps()
        {
            IList<Ip> result = new List<Ip>();

            for (int i = 1; i<=2; i++)
            {
                Ip ip = new Ip();
                ip.IpId = i;
                    ip.SubnetId = i;
                    ip.Address = "192.168." + i + ".1";
                    ip.Name = "Subnet" + i + "-IP";
                    ip.Purpose = "Subnet" + i + "-IP";
                    ip.Url = "http://" + ip.Address;
                    result.Add(ip);
                for(int i2 = 10; i2<=20; i2++)
                {
                    Ip ip2 = new Ip();
                    ip2.IpId = i * i2;
                    ip2.SubnetId = i;
                    ip2.Address = "192.168." + i + "." + i2;
                    ip2.Name = "Subnet" + i + "-IP" + i2;
                    ip2.Purpose = "Subnet" + i + "-IP" + i2;
                    ip2.Url = "http://" + ip.Address;
                    result.Add(ip2);
                }
            }
            return result.AsQueryable<Ip>();
        }
}

}
