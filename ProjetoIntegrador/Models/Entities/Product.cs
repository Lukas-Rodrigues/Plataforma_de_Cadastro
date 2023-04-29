using ProjetoIntegrador.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Models.Entities
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public double Price { get; set; }
		ProductType productType { get; set; }
		public ICollection<Stock> Estoques { get; set; }
		public ICollection<Order_Item> Order_Itens { get; set; }
	}
}
