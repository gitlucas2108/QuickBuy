using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;


namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            //throw new System.NotImplementedException();

            //geralmente declara chave primaria primeiro
            builder.HasKey(p => p.Id);

            //Builder utiliza o padrão Fluent
            builder.Property(p => p.Nome)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(p => p.Descricao)
                   .IsRequired()
                   .HasMaxLength(400);


            builder.Property(p => p.Preco)
                   .IsRequired()
                   .HasColumnType("FLOAT") //define o tipo de dado
                   .HasMaxLength(50);            

        }
    }
}
