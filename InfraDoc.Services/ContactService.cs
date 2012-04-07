using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Services
{
    public class ContactService
    {
                IContactRepository _repository = null;

        /// <summary>
        /// Creates a Contact Service based on the passed in repository.
        /// </summary>
        /// <param name="repository">An ISiteRepository</param>
        public ContactService(IContactRepository repository)
        {
            _repository = repository;
            if (_repository == null)
                throw new Exception("Repository cannot be null");
        }

        /// <summary>
        /// Gets the sites from the DB.
        /// </summary>
        /// <returns>ContactCollection</returns>
        public IList<Contact> GetContacts()
        {
            return _repository.GetContacts().ToList();
        }

        public IList<Contact> GetContactsBySite(int siteId)
        {
            return _repository.GetContacts().WithSite(siteId).ToList();
        }

        public Contact GetContactByID(int id)
        {
            return _repository.GetContacts().WithID(id).Single();
        }
    }
}
