using Domain;
using Domain.Entities;
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
    public partial class RegistrarFrm : Form
    {
        public IProductoRepository productoRepository;
        public int Count;
        public RegistrarFrm()
        {
            this.productoRepository = productoRepository;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Productos p = new Productos()
            {
                Id = Count++,
                Nombre = txtBoxNombre.Text,
                Description = txtBoxDescripcion.Text,
                Precio = (int)numericUpDown1.Value,
                Vencimiento = dateTimePicker1.Value,
                Categoria = (Domain.Enum.Categoria)cmbBoxCategorias.SelectedIndex,
            };
            productoRepository.Create(p);
        }

        private void RegistrarFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
