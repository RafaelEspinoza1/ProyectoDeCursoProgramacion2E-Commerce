using ProyectoDeCursoE_commerce.Data;
using ProyectoDeCursoE_commerce.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class Administracion : Form
    {
        private ECommerceContext db = new ECommerceContext();
        public Administracion()
        {
            InitializeComponent();
            txtContraseña1.UseSystemPasswordChar = true;
            txtContraseña1.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseña1.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V
            txtContraseñaAdmin.UseSystemPasswordChar = true;
            txtContraseñaAdmin.ContextMenuStrip = null; // Desactiva click derecho
            txtContraseñaAdmin.ShortcutsEnabled = false; // Desactiva Ctrl+C, Ctrl+X, Ctrl+V

        }
        private void CargarDatos()
        {
            dgvUsuarios.DataSource = db.Usuarios.ToList();

            var vendedor = db.Vendedores.
                    Include(v => v.Usuario).
                    Select(v => new
                    {
                        v.VendedorId,
                        v.NumeroDeCuenta,
                        v.Ingresos,
                        v.UsuarioID,
                        v.Usuario.Nombre,
                        v.direccionOrigen,
                        v.LatitudOrigen,
                        v.LongitudOrigen
                    }


                    ).ToList();
            dgvVendedores.DataSource = vendedor;

            var productos = db.Productos.
                    Include(p => p.Vendedor).
                    Select(p => new
                    {
                        p.ProductoId,
                        p.NombreProducto,
                        p.Descripcion,
                        p.Precio,
                        p.Tipo,
                        p.Cantidad,
                        p.Estado,
                        p.Vendedor.VendedorId,
                        p.Vendedor.NumeroDeCuenta,
                    }).ToList();
            dgvProductos.DataSource = productos;

            var compras = db.Compras.
                    Select(c => new
                    {
                        c.CompraId,
                        c.UsuarioId,
                        c.CuentaUsuario,
                        c.precio,
                        c.Cantidad,
                        c.Envio,
                        c.PrecioTotal,
                        c.Fecha,
                        c.ProductoId,
                        c.VendedorId,
                        c.DireccionOrigen,
                        c.LatitudOrigen,
                        c.LongitudOrigen,
                        c.DireccionDestino,
                        c.LatitudDestino,
                        c.LongitudDestino
                    }).ToList();
            dgvCompras.DataSource = compras;

            var ingresosECommerce = db.IngresosECommerce.
                    Include(i => i.Usuario).
                    Select(i => new
                    {
                        i.IngresoId,
                        i.Cantidad,
                        i.Descripcion,
                        i.UsuarioId,
                        i.Fecha,
                        i.Usuario.Nombre
                    }).ToList();
            dgvIngresosECommerce.DataSource = ingresosECommerce;
            lblIngresosECommece.Text = "Ingresos totales de E-Commerce: " + db.IngresosECommerce.Sum(i => i.Cantidad).ToString("C2");
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
            checkBoxContraseña1Visible.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "FormInicio";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Cargando datos, espere un momento...", "Cargando", MessageBoxButtons.OK, MessageBoxIcon.Information);

                progressBarCarga.Visible = true;

                await Task.Run(() =>
                {
                    // Llamamos al método que ya tenés
                    CargarDatos();
                    Invoke((MethodInvoker)CargarDatos); // Esto asegura que los DataGridView se actualicen en el hilo de la UI
                });

                progressBarCarga.Visible = false;

                MessageBox.Show("Datos cargados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                progressBarCarga.Visible = false;
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Size = new Size(1386, 671);
            groupBoxIngresar.Visible = false;
            btnCerrar.Visible = false;
            tabControl1.Visible = true;

        }
        private void checkBoxContraseña1Visible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseña1Visible.Checked)
            {
                // Mostrar el texto
                txtContraseña1.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseña1.UseSystemPasswordChar = true;
            }
        }
        private void checkBoxContraseñaCorreoVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContraseñaCorreoVisible.Checked)
            {
                // Mostrar el texto
                txtContraseñaAdmin.UseSystemPasswordChar = false;
            }
            else
            {
                // Ocultar el texto
                txtContraseñaAdmin.UseSystemPasswordChar = true;
            }
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
