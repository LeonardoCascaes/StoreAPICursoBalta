using Store.Domain.StoreContext.ValueObjects;
using System.Collections.Generic;

namespace Store.Domain.StoreContext.Entities
{
    public class Customer
    {
        public Customer(Name fullName, Document document, Email email, string phone)
        {
            FullName = fullName;
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        public Name FullName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses { get; private set; }

        public override string ToString()
        {
            return FullName.ToString();
        }
    }
}
