using Store.Domain.StoreContext.ValueObjects;
using Xunit;

namespace Store.Tests.Domain.ValueObjects
{
    public class DocumentTests
    {
        private readonly Document validDocument;
        private readonly Document invalidDocument;

        public DocumentTests()
        {
            validDocument = new Document("28659170377");
            invalidDocument = new Document("12345678910");
        }

        [Fact]
        public void DeveRetornarNotificacaoQuandoDocumentoNaoForValido()
        {
            Assert.False(invalidDocument.IsValid);
            Assert.Equal(1, invalidDocument.Notifications.Count);
        }

        [Fact]
        public void NaoDeveRetornarNotificacaoQuandoDocumentoForInvalido()
        {
            Assert.True(validDocument.IsValid);
            Assert.Equal(0, validDocument.Notifications.Count);
        }
    }
}
