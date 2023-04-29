using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Models.Entities
{
	public class Order_Item
	{
		public int orderItemId { get; set; }
		public int OrderId { get; set; }
		public virtual Order Order { get; set; }
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		public decimal Price { get; set; }
		public int Amount { get; set; }

	}
}
