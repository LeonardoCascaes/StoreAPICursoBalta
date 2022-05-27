using Store.Shared.Commands;

namespace Store.Domain.StoreContext.Commands.CustomerCommands.Outputs
{
    public class CreateCustomerCommandResult : CommandResult
    {
        public CreateCustomerCommandResult(string message, bool success, object data) : base(message, success, data)
        {
        }
    }
}
