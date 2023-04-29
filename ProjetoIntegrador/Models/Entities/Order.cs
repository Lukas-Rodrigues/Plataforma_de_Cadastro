using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Models.Entities
{
	public class Order
	{
		public int OrderId { get; set; }
		public DateTime Dateorder { get; set; }
		public virtual Client Client { get; set; }
		public virtual ICollection<Order_Item> Order_Itens { get; set; }

	}
}
