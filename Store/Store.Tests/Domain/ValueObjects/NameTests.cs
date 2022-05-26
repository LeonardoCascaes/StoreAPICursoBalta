using Store.Domain.StoreContext.ValueObjects;
using Xunit;

namespace Store.Tests.Domain.ValueObjects
{
    public class NameTests
    {
        [Fact]
        public void DeveRetornarNotificacaoQuandoNomeNaoForValido()
        {
            var name = new Name("", "Cascaes");
            Assert.False(name.IsValid);
            Assert.Equal(1, name.Notifications.Count);
        }
    }
}
