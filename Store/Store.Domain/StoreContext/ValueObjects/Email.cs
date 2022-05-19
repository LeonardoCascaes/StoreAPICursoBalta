using FluentValidator;
using FluentValidator.Validation;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public string Address { get; private set; }

        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
                    .Requires()
                    .IsEmail(address, "Email", "O e-mail é inválido")
            );
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
