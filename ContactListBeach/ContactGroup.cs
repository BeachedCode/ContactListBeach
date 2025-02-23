using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListBeach
{
    public class ContactGroup : List<Contact>
    {
        public string GroupName { get; set; }

        public ContactGroup(string name, List<Contact> contacts) : base(contacts)
        {
            GroupName = name;
        }
    }
}
