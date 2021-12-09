using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
    public interface IProductServices : IServices<Productos>
    {
        ICollection<Productos> Filtrar(Func<Productos, bool> Filtro);
                                                                                                     
		double InventarioFinal();
		void Update(Productos t);
	}
}
