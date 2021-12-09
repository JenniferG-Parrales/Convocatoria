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
    public partial class MenuFrm : Form
    {
        public MenuFrm(AppCore.Interfaces.IProductServices productServices)
        {
            InitializeComponent();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            RegistrarFrm MenuF = new RegistrarFrm();
            MenuF.Show();
            this.Hide();
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarFrm MenuF = new BuscarFrm();
            MenuF.Show();
            this.Hide();
        }
    }
}
