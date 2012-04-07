using System.Linq;

namespace InfraDoc.Data.Interfaces
{
    public interface ISiteRepository
    {
        IQueryable<Site> GetSites();
    }
}
