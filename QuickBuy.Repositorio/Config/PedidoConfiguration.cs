using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //throw new System.NotImplementedException();

            //geralmente declara chave primaria primeiro
            builder.HasKey(p => p.Id);

            //Builder utiliza o padrão Fluent           

            builder.Property(ped => ped.Cidade)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(ped => ped.DataPedido)
                   .IsRequired();
                   //.HasMaxLength(50);

            builder.Property(ped => ped.DataPrevisaoEntrega)
                   .IsRequired();
                   //.HasMaxLength(50);

            builder.Property(ped => ped.CEP)
                    .IsRequired()
                    .HasMaxLength(10);

            builder.Property(ped => ped.EndereCompleto)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(ped => ped.NumeroEndereco)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(ped => ped.Cidade)
                    .IsRequired()
                    .HasMaxLength(10);

            builder.Property(ped => ped.Estado)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(ped => ped.FormaPagamento)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(ped => ped.FormaPagamentoId)
                   .IsRequired()
                   .HasMaxLength(50);            

            builder.Property(ped => ped.UsuarioId)
                   .IsRequired()
                   .HasMaxLength(50);

        }
    }
}
