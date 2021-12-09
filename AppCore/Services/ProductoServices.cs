using AppCore.Interfaces;
using Domain;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
	public class ProductoServices : BaseServices<Productos>, IProductServices
	{
		private IProductoRepository Repository{get; set;}
		public ProductoServices(IProductoRepository repository) : base(repository)
		{
			this.Repository = repository;
		}

		public ICollection<Productos> Filtrar(Func<Productos, bool> Filtro)
		{
			return Repository.Filtrar(Filtro);
		}

		public double InventarioFinal()
		{
			return Repository.InventarioFinal();
		}

		public void Update(Productos t)
		{
			Repository.Update(t);
		}
	}
}
