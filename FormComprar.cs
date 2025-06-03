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

namespace ProyectoDeCursoE_commerce
{
    public partial class FormComprar : Form
    {
        private ECommerceContext db = new ECommerceContext();
        public FormComprar()
        {
            InitializeComponent();
            MostrarProductosAleatorios();
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            flowLayoutPanelFiltros.Visible = true;
            btnBuscar.Enabled = false;
        }


        private void MostrarProductosAleatorios()
        {
            flpProductos.Controls.Clear();

            // Simulación de productos con imágenes para pruebas
            var productosSimulados = new List<Productos>();

            for (int i = 1; i <= 10; i++)
            {
                var producto = new Productos
                {
                    ProductoId = i,
                    NombreProducto = "Producto " + i,
                    Precio = 10m * i,
                    Imagenes = new List<ImagenProducto>()
                };

                // Crear una imagen en blanco simulada (100x100 px)
                Bitmap bmp = new Bitmap(100, 100);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.AliceBlue);
                    g.DrawString($"Img {i}", new Font("Arial", 12), Brushes.Black, new PointF(10, 40));
                }

                // Convertir imagen a byte[]
                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    producto.Imagenes.Add(new ImagenProducto { Imagen = ms.ToArray() });
                }

                productosSimulados.Add(producto);
            }

            var random = new Random();
            var seleccionados = productosSimulados.OrderBy(p => random.Next()).Take(10).ToList();

            foreach (var producto in seleccionados)
            {
                GroupBox grupo = new GroupBox
                {
                    Width = 154,
                    Height = 150,
                    Text = ""
                };

                PictureBox pic = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 140,
                    Height = 100,
                    Top = 10,
                    Left = 7
                };

                var imagenBytes = producto.Imagenes.FirstOrDefault()?.Imagen;
                if (imagenBytes != null)
                {
                    using (var ms = new MemoryStream(imagenBytes))
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                }

                Label lbl = new Label
                {
                    AutoSize = false,
                    Width = 140,
                    Height = 40,
                    Top = 110,
                    Left = 7,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{producto.NombreProducto}\n{producto.Precio:C2}"
                };

                grupo.Controls.Add(pic);
                grupo.Controls.Add(lbl);
                flpProductos.Controls.Add(grupo);
            }
        }


    }
}
