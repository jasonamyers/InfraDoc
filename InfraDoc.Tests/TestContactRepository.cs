using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Tests
{
    public class TestContactRepository : IContactRepository
    {
        public IQueryable<Contact> GetContacts()
        {
            IList<Contact> result = new List<Contact>();

            for (int i = 1; i<=2; i++)
            {
                Contact c = new Contact();
                c.ContactId = i;
                c.SiteId = 1;
                c.Name = "TestUser" + i;
                c.Phone = "666-666-666" + i;
                c.Email = "Test" + i + "@user.com";
                result.Add(c);
            }
 
            return result.AsQueryable<Contact>();
        }
    }
}
