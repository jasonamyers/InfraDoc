using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfraDoc.Data;
using InfraDoc.Data.Filters;
using InfraDoc.Data.Interfaces;

namespace InfraDoc.Services
{
    public class SiteService
    {
        ISiteRepository _repository = null;

        /// <summary>
        /// Creates a SiteService based on the passed in repository.
        /// </summary>
        /// <param name="repository">An ISiteRepository</param>
        public SiteService(ISiteRepository repository)
        {
            _repository = repository;
            if (_repository == null)
                throw new Exception("Repository cannnot be null");
        }

        /// <summary>
        /// Gets the sites from the DB.
        /// </summary>
        /// <returns>SiteCollection</returns>
        public IList<Site> GetSites()
        {
            return _repository.GetSites().ToList();
        }

        public Site GetSiteByID(int id)
        {
            return _repository.GetSites().WithID(id).Single();
        }
    }
}
