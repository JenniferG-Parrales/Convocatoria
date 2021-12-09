using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
	public interface IServices<T>
	{
		T[] Read();
		void Create(T t);
		void Delete(T t);
		int GetLastId();
	}
}
