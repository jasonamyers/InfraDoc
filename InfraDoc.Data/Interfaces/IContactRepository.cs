using System.Linq;

namespace InfraDoc.Data.Interfaces
{
    public interface IContactRepository
    {

            IQueryable<Contact> GetContacts();
        
    }
}
