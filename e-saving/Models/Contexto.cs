using AspNetCoreGeneratedDocument;
using Microsoft.EntityFrameworkCore;

//Contexto, área responsável pela interação com o banco de dados

namespace e_saving.Models 
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }
        
        public DbSet<Cliente> clientes {get; set;}

        public DbSet<Item> items {get; set;}

        public DbSet<Fornece> fornece {get; set;}

        public DbSet<PontoColeta> pontosColeta {get; set;}

        public DbSet<Parceiro> parceiros {get; set;}

        public DbSet<ContaBanco> contasBanco {get; set;}

        public DbSet<Comprador> compradores {get; set;}

        public DbSet<Estoque> estoques {get; set;}

        public DbSet<Compra> compra {get; set;}

        public DbSet<Funcionario> funcionarios {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configura a chave composta de Fornece
            modelBuilder.Entity<Fornece>().HasKey(f => new {f.IdItem, f.CpfCliente});
        
            //Relacionanamento de Item com Fornece
            modelBuilder.Entity<Fornece>()
                .HasOne(f => f.Item)
                .WithMany(i => i.Fornecimentos)
                .HasForeignKey(f => f.IdItem);
            
            //relacionamento de Item com estoque 
            modelBuilder.Entity<Item>()
                .HasOne(f => f.Estoque)
                .WithMany(i => i.Itens)
                .HasForeignKey(f => f.IdEstoque);

            //Relacionamente de Cliente com Fornece
            modelBuilder.Entity<Fornece>()
                .HasOne(f => f.Cliente)
                .WithMany(i => i.Fornecimentos)
                .HasForeignKey(f => f.CpfCliente);
            
            //Relacionamento entre Item e PontoColeta
            modelBuilder.Entity<Item>()
                .HasOne(i => i.PontoColeta)
                .WithMany(p =>p.Itens)
                .HasForeignKey(i => i.IdPontoColeta);

            //relacionamentos do ponto de coleta com Paceiro
            modelBuilder.Entity<PontoColeta>()
                .HasOne(i => i.Parceiro)
                .WithMany(p => p.PontosColeta)
                .HasForeignKey(i => i.CpfParceiro);
            
            //Chave composta banco
            modelBuilder.Entity<ContaBanco>().HasKey(f => new {f.Agencia, f.Banco, f.NumeroConta});

            //relacionamentos do banco:
            //relacionamento com Parceiro
             modelBuilder.Entity<ContaBanco>()
                .HasOne(i => i.Parceiro)
                .WithMany(p => p.ContasBancos)
                .HasForeignKey(i => i.CpfParceiro);
            //relacionamento com Comprador
             modelBuilder.Entity<ContaBanco>()
                .HasOne(i => i.Comprador)
                .WithMany(p => p.ContasBancos)
                .HasForeignKey(i => i.CnpjComprador);
            //relacionamento com Cliente
             modelBuilder.Entity<ContaBanco>()
                .HasOne(i => i.Cliente)
                .WithMany(p =>p.ContasBancos)
                .HasForeignKey(i => i.CpfCliente);
            
            //Configura a chave composta de Compra
            modelBuilder.Entity<Compra>().HasKey(f => new {f.IdEstoque, f.CpnjComprador});
        
            //Relacionanamento de Compra com Estoque
            modelBuilder.Entity<Compra>()
                .HasOne(f => f.Estoque)
                .WithMany(i => i.Compras)
                .HasForeignKey(f => f.IdEstoque);
            //Relacionamente de Compra com Comprador
            modelBuilder.Entity<Compra>()
                .HasOne(f => f.Comprador)
                .WithMany(i => i.Compras)
                .HasForeignKey(f => f.CpnjComprador);

            //Relacionam de Funcionario com Estoque
            modelBuilder.Entity<Funcionario>()
                .HasOne(f => f.Estoque)
                .WithMany(i => i.Funcionarios)
                .HasForeignKey(f => f.IdEstoque);
     
        }
    }
}