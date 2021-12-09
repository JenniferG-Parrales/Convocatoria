using AppCore.Interfaces;
using AppCore.Services;
using Architecture.Repository;
using Autofac;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var builder = new ContainerBuilder();

			builder.RegisterType<ProductRepository>().As<IProductoRepository>();
			builder.RegisterType<ProductoServices>().As<IProductServices>();


			var container = builder.Build();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MenuFrm(container.Resolve<IProductServices>()));
		}
	}
}
