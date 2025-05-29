using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProyectoDeCursoE_commerce
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void btnContraseña1_Click(object sender, EventArgs e)
        {
            string contraseña = txtContraseña1.Text.Trim();
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña1.Focus();
                return;
            }
            if (contraseña != "12345678")
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContraseña1.Focus();
                return;
            }
            MessageBox.Show("Contraseña correcta. Ingrese el correo y contraseña de el administrador.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            groupBoxIngresar.Visible = true;
            btnContraseña1.Visible = false;
            txtContraseña1.Visible = false;
            lblContraseña1.Visible = false;
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "FormInicio";
            this.DialogResult = DialogResult.OK;
            this.Close(); 

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
