using NerdStore.Core.DomainObjects;

namespace NerdStore.Vendas.Domain.Tests
{
    public class PedidoItemTests
    {

        [Fact(DisplayName = "Novo Item Pedido com unidades a baixo do permitido.")]
        [Trait("Categoria", "Vendas - Pedido Item")]
        public void AdicionarItemPedido_UnidadesItemAbaixoDoPermitido_DeveRetornarException()
        {
            Assert.Throws<DomainException>(() => new PedidoItem(Guid.NewGuid(), "Produdo Tests", Pedido.MIN_UNIDADES_ITEM - 1, 100));
        }
    }
}
