using ProyectoDeCursoE_commerce.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeCursoE_commerce
{
    public partial class FormComprar : Form
    {
        public FormComprar()
        {
            InitializeComponent();
            CargarProductosEnFlowLayout();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFiltros.Visible = true;
            btnBuscar.Enabled = false;
        }

        private void CargarProductosEnFlowLayout()
        {
            

            
        }
    }
}