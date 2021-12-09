using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Repository
{
	public abstract class BaseRepository<T> : IModel<T>
	{
		protected List<T> Datos;
		protected BaseRepository()
		{
			Datos = new List<T>();
		}
		public void Create(T t)
		{
			if (t == null)
			{
				new Exception("El objeto no puede ser nulo");
				return;
			}

			Datos.Add(t);
		}

		public void Delete(T t)
		{
			Datos.Remove(t);
		}

		public int GetLastId()
		{
			return Datos.Count == 0 ? 1: (int)Datos[Datos.Count - 1].GetType().GetProperty("Id").GetValue(Datos[Datos.Count]);
		}

		public T[] Read()
		{
			return Datos.ToArray();
		}
	}
}
