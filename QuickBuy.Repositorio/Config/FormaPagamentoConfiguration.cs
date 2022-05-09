using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            //throw new System.NotImplementedException();
            //builder.Haskey

            //geralmente declara chave primaria primeiro
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Nome)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(i => i.Descricao)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
