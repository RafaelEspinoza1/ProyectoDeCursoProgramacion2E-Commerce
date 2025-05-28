namespace ProyectoDeCursoE_commerce
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            toolTip1.SetToolTip(pictureBoxConfig, "Opciones");
            toolTip1.SetToolTip(pictureBoxCerrarInicioSesion, "Cerrar");
            toolTip1.SetToolTip(txtCorreo, "Correo electronico");
        }
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxInicioDeSesion.Visible = true;
                btnIniciarSesion.Visible = false;
                btnRegistrase.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inerperado al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxInicioDeSesion.Visible = false;
                groupBoxRegristrarse.Visible = false;
                btnIniciarSesion.Visible = true;
                btnRegistrase.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cancelar inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {

            groupBoxRegristrarse.Visible = true;
            btnRegistrase.Visible = false;
            btnIniciarSesion.Visible = false;
        }

        // Cierra el formulario y abre el formulario PaginaPrincipal.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lista de dominios válidos
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

            // Verificar si el correo termina en alguno de los dominios permitidos
            bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

            if (!esValido)
            {
                MessageBox.Show("Correo no válido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // También puedes validar que tenga algo antes del dominio
            int posicionArroba = correo.IndexOf('@');
            if (posicionArroba <= 0)
            {
                MessageBox.Show("Correo no válido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("Bienvenido a E-Commerce", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        

       
        private void btnTerminarRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreoRegistro.Text.Trim();
            string contraseña = txtContraseñaRegistro.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

            // Verificar si el correo termina en alguno de los dominios permitidos
            bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

            if (!esValido)
            {
                MessageBox.Show("Correo no válido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // También puedes validar que tenga algo antes del dominio
            int posicionArroba = correo.IndexOf('@');
            if (posicionArroba <= 0)
            {
                MessageBox.Show("Correo no válido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("Bienvenido a E-Commerce", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
 