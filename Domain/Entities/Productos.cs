using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Productos
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Description { get; set; }
		public int Existencia { get; set; }
		public double Precio { get; set; }
		public DateTime Vencimiento { get; set; }
		public Categoria Categoria { get; set; }
	}
}
