using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IModel<T>
	{
		T[] Read();
		void Create(T t);
		void Delete(T t);
		int GetLastId();
	}
}
