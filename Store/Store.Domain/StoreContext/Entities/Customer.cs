using Store.Domain.StoreContext.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace Store.Domain.StoreContext.Entities
{
    public class Customer
    {
        private readonly IList<Address> _addresses;

        public Customer(Name fullName, Document document, Email email, string phone)
        {
            FullName = fullName;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }

        public Name FullName { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            //Validar Endereço
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return FullName.ToString();
        }
    }
}
