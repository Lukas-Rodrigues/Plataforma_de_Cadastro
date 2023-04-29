using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador
{
	public class bancoContext:DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Order_Item> Order_Itens { get; set; }
		public DbSet<Estoque> Estoques { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("localhost\\sqlexpress;initial catalog=Db_SistemaContatos;Integrated Security=True;Encrypt=Fals");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Client>()
				.HasKey(c => c.Id);

			modelBuilder.Entity<Product>()
				.HasKey(p => p.Id);

			modelBuilder.Entity<Order>()
				.HasKey(p => p.OrderId);

			modelBuilder.Entity<Order_Item>()
				.HasKey(pi => pi.orderItemId);

			modelBuilder.Entity<Stock>()
				.HasKey(e => e.Id);

			modelBuilder.Entity<Order>()
				.HasOne(p => p.Client)
				.WithMany(c => c.Order)
				.HasForeignKey(p => p.OrderId);

			modelBuilder.Entity<Order_Item>()
				.HasOne(pi => pi.Order)
				.WithMany(p => p.Order_Itens)
				.HasForeignKey(pi => pi.OrderId);

			modelBuilder.Entity<Order_Item>()
				.HasOne(pi => pi.Product)
				.WithMany(p => p.Order_Itens)
				.HasForeignKey(pi => pi.ProductId);

			modelBuilder.Entity<Stock>()
				.HasOne(e => e.Product)
				.WithMany(p => p.Estoques)
				.HasForeignKey(e => e.Id);
		}

		
	}
}
