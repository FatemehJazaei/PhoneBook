using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain
{
    public class User
    {
        public Guid Id;
        public string Name;
        public string Email; 
        public string PasswordHash;
        public DateTime CreatedAt;
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
