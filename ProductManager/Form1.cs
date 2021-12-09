using AppCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
	public partial class Form1 : Form
	{
		private IProductServices Services{get;set;}
	
		public Form1(IProductServices services)
		{
			this.Services = services;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
