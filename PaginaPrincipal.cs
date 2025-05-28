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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        // Cierra el formulario y abre el formulario FormInicio.
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("E-Commerce le desea buen dia, vuelva pronto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error inesperado al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
