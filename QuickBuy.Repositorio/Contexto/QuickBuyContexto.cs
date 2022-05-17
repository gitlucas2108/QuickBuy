using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
//using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto: DbContext 
    {       
        public  DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }        
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        //public DbSet<FormaPagamento> FormasPagamentos { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de Mapeamento aqui...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            //modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            //Teste de carga em tabela
            modelBuilder.Entity<Produto>().HasData(
                                        new Produto()
                                        {
                                            Id = 1,
                                            Nome = "PRODUTO 1",
                                            Descricao = "Produto cadastrado pelo QuickBuy.",
                                            Preco = 10
                                        },
                                        new Produto()
                                        {
                                            Id = 2,
                                            Nome = "PRODUTO 2",
                                            Descricao = "Produto cadastrado pelo QuickBuy.",
                                            Preco = 20
                                        }, new Produto()
                                        {
                                            Id = 3,
                                            Nome = "PRODUTO 3",
                                            Descricao = "Produto cadastrado pelo QuickBuy.",
                                            Preco = 30.30M
                                        }
                                        );

            base.OnModelCreating(modelBuilder);
        }

    } 
}
