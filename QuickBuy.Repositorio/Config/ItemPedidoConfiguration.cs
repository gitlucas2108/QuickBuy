using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            //throw new System.NotImplementedException();

            //geralmente declara chave primaria primeiro
            builder.HasKey(i => i.Id);

            builder.Property(i => i.ProdutoId)
                   .IsRequired();

            builder.Property(i => i.Quantidade)
                   .IsRequired();           


        }
    }
}
