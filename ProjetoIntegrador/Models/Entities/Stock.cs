using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Models.Entities
{
	public class Stock
	{
		public int Id { get; set; }
		public int ProdutoId { get; set; }
		public virtual Product Product { get; set; }
		public int Amount { get; set; }


	}
}
