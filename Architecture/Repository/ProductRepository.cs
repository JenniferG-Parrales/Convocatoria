using Domain;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Repository
{
	public class ProductRepository : BaseRepository<Productos>, IProductoRepository
	{
		public ICollection<Productos> Filtrar(Func<Productos, bool> Filtro)
		{
			return Datos.Where(Filtro).ToList();
		}

		public double InventarioFinal()
		{
			return Datos.Sum(x => x.Existencia * x.Precio);
		}

		public void Update(Productos t)
		{
			for(int i=0; i<Datos.Count; i++)
			{
				if (t.Id == Datos[i].Id)
				{
					Datos.Insert(i, Datos[i]);
					break;
				}
			}
		}
	}
}
