using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
	public interface IProductoRepository: IModel<Productos>
	{
		ICollection<Productos> Filtrar(Func<Productos,bool> Filtro);
		double InventarioFinal();
		void Update(Productos t);
	}
}
