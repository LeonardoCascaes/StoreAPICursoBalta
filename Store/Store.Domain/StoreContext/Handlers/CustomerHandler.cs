using FluentValidator;
using Store.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using Store.Shared.Commands;
using System;

namespace Store.Domain.StoreContext.Handlers
{
    public class CustomerHandler : Notifiable,
        ICommandHandler<CreateCustomerCommand>,
        ICommandHandler<AddAddressCommand>
    {
        public ICommandResult Handle(CreateCustomerCommand command)
        {
            throw new NotImplementedException();
        }
        public ICommandResult Handle(AddAddressCommand command)
        {
            throw new NotImplementedException();
        }

    }
}
