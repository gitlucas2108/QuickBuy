using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {  
            //geralmente declara chave primaria primeiro
            builder.HasKey(u => u.Id);

            //Builder utiliza o padrão Fluent
            builder
                .Property(u => u.Email)
                .IsRequired() //identifica que é obrigatorio = IS NOT NULL
                .HasMaxLength(50); // tamanho maximo

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50);
                //.HasColumnType("NVARCHAR"); //define o tipo de dado

            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength (50);

            builder
                //UMA DAS PARTES FUNDAMENTAIS DA CONFIG DE RELACIONAMENTO ENTRE AS CLASSES 
                //A NIVEL DE REGRA DE NEGOCIO DE ARAMAZENAMENTO DE DADOS EM BANCO
                .HasMany(u => u.Pedidos) //varios Pedidos
                .WithOne(p => p.Usuario); // relacionado a um unico Usuario


        }
    }
}
