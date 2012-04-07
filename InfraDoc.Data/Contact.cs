using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraDoc.Data
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Site Site { get; set; }

        public Contact()
        {
            
        }

        public Contact(int SiteId, string name, string phoneNumber, string eMail)
        {
            this.SiteId = SiteId;
            this.Name = name;
            this.Phone = phoneNumber;
            this.Email = eMail;
        }
    }
}
