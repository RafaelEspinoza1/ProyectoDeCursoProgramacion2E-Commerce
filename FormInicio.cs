namespace ProyectoDeCursoE_commerce
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnConfig, "Opciones");
            toolTip1.SetToolTip(btnCerrarInicioSesion, "Cerrar");
            toolTip1.SetToolTip(txtCorreo, "Correo electronico");
            toolTip1.SetToolTip(btnCerrarOpciones, "Cerrar");
            toolTip1.SetToolTip(btnAdmin, "Solo admin");
            toolTip1.SetToolTip(btnCerrarRegistro, "Cerrar");
            toolTip1.SetToolTip(txtCorreoRegistro, "Correo electronico");
            toolTip1.SetToolTip(checkBoxContrase�aRegistroVisible, "Hacer visible Contrase�a");
            toolTip1.SetToolTip(checkBoxContrase�aInicioDeSesionVisible, "Hacer visible Contrase�a");
            // Esto sirve para que la contrase�a se muestre como puntos
            txtContrase�aRegistro.UseSystemPasswordChar = true;
            txtContrase�aRegistro.ContextMenuStrip = null; // Desactiva click derecho
            txtContrase�aRegistro.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            txtContrase�a.UseSystemPasswordChar = true;
            txtContrase�a.ContextMenuStrip = null; // Desactiva click derecho
            txtContrase�a.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
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
                MessageBox.Show($"Error inerperado al iniciar sesi�n: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxInicioDeSesion.Visible = false;
                groupBoxRegristrarse.Visible = false;
                btnIniciarSesion.Visible = true;
                btnRegistrase.Visible = true;
                flowLayoutPanelOpciones.Visible = false;
                btnConfig.Visible = true;
                txtApellido.Clear();
                txtContrase�aRegistro.Clear();
                txtCorreoRegistro.Clear();
                txtNombre.Clear();
                mtxtTelefono.Clear();
                txtCorreo.Clear();
                txtContrase�a.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al cancelar inicio de sesi�n: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrase_Click(object sender, EventArgs e)
        {
            try
            {
                groupBoxRegristrarse.Visible = true;
                btnRegistrase.Visible = false;
                btnIniciarSesion.Visible = false;
            }catch(Exception ex)
            {
                MessageBox.Show($"Error inesperado al registrarte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        // Cierra el formulario y abre el formulario PaginaPrincipal.
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrase�a = txtContrase�a.Text.Trim();
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lista de dominios v�lidos
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

            // Verificar si el correo termina en alguno de los dominios permitidos
            bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

            if (!esValido)
            {
                MessageBox.Show("Correo no v�lido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Tambi�n puedes validar que tenga algo antes del dominio
            int posicionArroba = correo.IndexOf('@');
            if (posicionArroba <= 0)
            {
                MessageBox.Show("Correo no v�lido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("Bienvenido a E-Commerce", "Inicio de Sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Tag = "PaginaPrincipal";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




        private void btnTerminarRegistro_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto y los guarda en variables
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreoRegistro.Text.Trim();
            string contrase�a = txtContrase�aRegistro.Text.Trim();
            string telefono = mtxtTelefono.Text.Trim();

            // Validar que los campos no est�n vac�os
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrase�a) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que la contrase�a tenga al menos 8 caracteres
            if (contrase�a.Length < 8)
            {
                MessageBox.Show("La contrase�a debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrase�aRegistro.Focus();
                return;
            }

            // Validar el formato del correo electr�nico
            string[] dominiosPermitidos = { "@gmail.com", "@hotmail.com", "@yahoo.com" };

            // Verificar si el correo termina en alguno de los dominios permitidos
            bool esValido = dominiosPermitidos.Any(d => correo.EndsWith(d));

            if (!esValido)
            {
                MessageBox.Show("Correo no v�lido. Solo se permiten dominios: @gmail.com, @hotmail.com o @yahoo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Tambi�n puedes validar que tenga algo antes del dominio
            int posicionArroba = correo.IndexOf('@');
            if (posicionArroba <= 0)
            {
                MessageBox.Show("Correo no v�lido. Falta nombre de usuario antes del dominio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // Si pasa todas las validaciones
            MessageBox.Show("Bienvenido a E-Commerce", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Tag = "PaginaPrincipal";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            flowLayoutPanelOpciones.Visible = true;
            btnConfig.Visible = false;
            groupBoxInicioDeSesion.Visible = false;
            groupBoxRegristrarse.Visible = false;
            btnIniciarSesion.Visible = true;
            btnRegistrase.Visible = true;
        }

        private void btnEcommerce_Click(object sender, EventArgs e)
        {
            MessageBox.Show("E-Commerce es una tienda en linea disponible para .....", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreguntas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�Que puedes hacer en E-Commerce? Comprar, verder, ....", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Tag = "Administracion";
            this.DialogResult = DialogResult.OK; 
            this.Close();

        }

        // Hace vicible la contrase�a en el registro y viceversa
        private void checkBoxContrase�aRegistroVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContrase�aRegistroVisible.Checked)
            {
                // Mostrar el texto
                txtContrase�aRegistro.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContrase�aRegistro.UseSystemPasswordChar = true;
            }
        }
        private void checkBoxContrase�aInicioDeSesionVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContrase�aInicioDeSesionVisible.Checked)
            {
                // Mostrar el texto
                txtContrase�a.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContrase�a.UseSystemPasswordChar = true;
            }
        }

    }
}
 