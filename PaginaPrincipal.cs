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
            MostrarFormularioEnTabPage();
        }
        // Cierra el formulario y abre el formulario FormInicio.
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("E-Commerce le desea buen dia, vuelva pronto.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Tag = "FormInicio";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cerrar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
            btnMenu.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            btnMenu.Visible = true;
        }
        private void MostrarFormularioEnTabPage()
        {
            // Crear instancia del formulario que se va a mostrar
            FormComprar formComprar = new FormComprar();

            // Configurar para que se comporte como control incrustado
            formComprar.TopLevel = false;
            formComprar.FormBorderStyle = FormBorderStyle.None;
            formComprar.Dock = DockStyle.Fill;

            // Agregar el formulario a los controles de la TabPage
            tabPageComprar.Controls.Clear(); // Opcional: limpia contenido anterior
            tabPageComprar.Controls.Add(formComprar);

            // Mostrar el formulario
            formComprar.Show();
        }

    }
}
