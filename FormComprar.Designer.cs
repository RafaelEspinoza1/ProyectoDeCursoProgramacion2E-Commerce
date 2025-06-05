namespace ProyectoDeCursoE_commerce
{
    partial class FormComprar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnFiltros = new Button();
            flowLayoutPanelFiltros = new FlowLayoutPanel();
            panelCerrarFiltro = new Panel();
            btnCerrarFiltros = new Button();
            flowLayoutPanelBtnsFiltros = new FlowLayoutPanel();
            btnTipo = new Button();
            btnPrecio = new Button();
            btnEstado = new Button();
            btnRestablecer = new Button();
            flowLayoutPanelSeleccionFiltro = new FlowLayoutPanel();
            lblPrecioMin = new Label();
            txtPrecioMin = new TextBox();
            lblPrecioMax = new Label();
            txtPrecioMax = new TextBox();
            cboEstado = new ComboBox();
            cboTipos = new ComboBox();
            btnListo = new Button();
            flpProductos = new FlowLayoutPanel();
            flowLayoutPanelFiltros.SuspendLayout();
            panelCerrarFiltro.SuspendLayout();
            flowLayoutPanelBtnsFiltros.SuspendLayout();
            flowLayoutPanelSeleccionFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(93, 13);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(286, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnFiltros
            // 
            btnFiltros.Location = new Point(399, 13);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new Size(75, 23);
            btnFiltros.TabIndex = 2;
            btnFiltros.Text = "Filtros";
            btnFiltros.UseVisualStyleBackColor = true;
            btnFiltros.Click += btnFiltros_Click;
            // 
            // flowLayoutPanelFiltros
            // 
            flowLayoutPanelFiltros.Controls.Add(panelCerrarFiltro);
            flowLayoutPanelFiltros.Controls.Add(flowLayoutPanelBtnsFiltros);
            flowLayoutPanelFiltros.Controls.Add(btnRestablecer);
            flowLayoutPanelFiltros.Location = new Point(480, 12);
            flowLayoutPanelFiltros.Name = "flowLayoutPanelFiltros";
            flowLayoutPanelFiltros.Size = new Size(219, 145);
            flowLayoutPanelFiltros.TabIndex = 3;
            flowLayoutPanelFiltros.Visible = false;
            // 
            // panelCerrarFiltro
            // 
            panelCerrarFiltro.Controls.Add(btnCerrarFiltros);
            panelCerrarFiltro.Location = new Point(3, 3);
            panelCerrarFiltro.Name = "panelCerrarFiltro";
            panelCerrarFiltro.Size = new Size(212, 32);
            panelCerrarFiltro.TabIndex = 6;
            // 
            // btnCerrarFiltros
            // 
            btnCerrarFiltros.BackgroundImage = Properties.Resources.cerrar;
            btnCerrarFiltros.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrarFiltros.Location = new Point(181, 0);
            btnCerrarFiltros.Name = "btnCerrarFiltros";
            btnCerrarFiltros.Size = new Size(31, 31);
            btnCerrarFiltros.TabIndex = 8;
            btnCerrarFiltros.UseVisualStyleBackColor = true;
            btnCerrarFiltros.Click += btnCerrarFiltros_Click;
            // 
            // flowLayoutPanelBtnsFiltros
            // 
            flowLayoutPanelBtnsFiltros.Controls.Add(btnTipo);
            flowLayoutPanelBtnsFiltros.Controls.Add(btnPrecio);
            flowLayoutPanelBtnsFiltros.Controls.Add(btnEstado);
            flowLayoutPanelBtnsFiltros.Location = new Point(3, 41);
            flowLayoutPanelBtnsFiltros.Name = "flowLayoutPanelBtnsFiltros";
            flowLayoutPanelBtnsFiltros.Size = new Size(86, 96);
            flowLayoutPanelBtnsFiltros.TabIndex = 6;
            // 
            // btnTipo
            // 
            btnTipo.Location = new Point(3, 3);
            btnTipo.Name = "btnTipo";
            btnTipo.Size = new Size(75, 23);
            btnTipo.TabIndex = 8;
            btnTipo.Text = "Tipo";
            btnTipo.UseVisualStyleBackColor = true;
            btnTipo.Click += btnTipo_Click;
            // 
            // btnPrecio
            // 
            btnPrecio.Location = new Point(3, 32);
            btnPrecio.Name = "btnPrecio";
            btnPrecio.Size = new Size(75, 23);
            btnPrecio.TabIndex = 9;
            btnPrecio.Text = "Precio";
            btnPrecio.UseVisualStyleBackColor = true;
            btnPrecio.Click += btnPrecio_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(3, 61);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 10;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnRestablecer
            // 
            btnRestablecer.Location = new Point(95, 41);
            btnRestablecer.Name = "btnRestablecer";
            btnRestablecer.Size = new Size(120, 23);
            btnRestablecer.TabIndex = 11;
            btnRestablecer.Text = "Restablecer todo";
            btnRestablecer.UseVisualStyleBackColor = true;
            btnRestablecer.Click += btnRestablecer_Click;
            // 
            // flowLayoutPanelSeleccionFiltro
            // 
            flowLayoutPanelSeleccionFiltro.Controls.Add(lblPrecioMin);
            flowLayoutPanelSeleccionFiltro.Controls.Add(txtPrecioMin);
            flowLayoutPanelSeleccionFiltro.Controls.Add(lblPrecioMax);
            flowLayoutPanelSeleccionFiltro.Controls.Add(txtPrecioMax);
            flowLayoutPanelSeleccionFiltro.Controls.Add(cboEstado);
            flowLayoutPanelSeleccionFiltro.Controls.Add(cboTipos);
            flowLayoutPanelSeleccionFiltro.Controls.Add(btnListo);
            flowLayoutPanelSeleccionFiltro.Location = new Point(93, 2);
            flowLayoutPanelSeleccionFiltro.Name = "flowLayoutPanelSeleccionFiltro";
            flowLayoutPanelSeleccionFiltro.Size = new Size(312, 121);
            flowLayoutPanelSeleccionFiltro.TabIndex = 9;
            flowLayoutPanelSeleccionFiltro.Visible = false;
            // 
            // lblPrecioMin
            // 
            lblPrecioMin.AutoSize = true;
            lblPrecioMin.Location = new Point(3, 0);
            lblPrecioMin.Name = "lblPrecioMin";
            lblPrecioMin.Size = new Size(85, 15);
            lblPrecioMin.TabIndex = 0;
            lblPrecioMin.Text = "Precio minimo";
            lblPrecioMin.Visible = false;
            // 
            // txtPrecioMin
            // 
            txtPrecioMin.Location = new Point(94, 3);
            txtPrecioMin.Name = "txtPrecioMin";
            txtPrecioMin.Size = new Size(51, 23);
            txtPrecioMin.TabIndex = 10;
            txtPrecioMin.Visible = false;
            txtPrecioMin.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecioMax
            // 
            lblPrecioMax.AutoSize = true;
            lblPrecioMax.Location = new Point(151, 0);
            lblPrecioMax.Name = "lblPrecioMax";
            lblPrecioMax.Size = new Size(86, 15);
            lblPrecioMax.TabIndex = 1;
            lblPrecioMax.Text = "Precio maximo";
            lblPrecioMax.Visible = false;
            // 
            // txtPrecioMax
            // 
            txtPrecioMax.Location = new Point(243, 3);
            txtPrecioMax.Name = "txtPrecioMax";
            txtPrecioMax.Size = new Size(56, 23);
            txtPrecioMax.TabIndex = 11;
            txtPrecioMax.Visible = false;
            txtPrecioMax.KeyPress += txtPrecio_KeyPress;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Items.AddRange(new object[] { "Cualquiera", "Nuevo", "Como nuevo", "Buen estado", "Aceptable" });
            cboEstado.Location = new Point(3, 32);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(149, 23);
            cboEstado.TabIndex = 10;
            cboEstado.Visible = false;
            // 
            // cboTipos
            // 
            cboTipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipos.FormattingEnabled = true;
            cboTipos.Items.AddRange(new object[] { "Cualquiera", "Herramientas", "Muebles", "Jardineria", "Electrodomesticos", "Hogar", "Libros, peliculas y musica", "Videojuegos", "Joyas y accesorios", "Bolsos y equipajes", "Ropa y calzado de hombre", "Ropa y calzado de mujer", "Juguetes y juegos", "Bebés y niños", "Productos para mascotas", "Salud y belleza", "Telefonos celulares", "Electromica e informatica", "Deportes y actividades al aire libre", "Instrumentos musicales", "Arte y manualidades", "Antigüedades y articulos de colección", "Autopartes", "Bicicletas", "Viviendas en venta", "Alquileres", "Autos y camionetas", "Motocicletas", "Todoterreno", "Casas rodantes y caravanas", "Embarcaciónes", "Remolques", "Otros" });
            cboTipos.Location = new Point(3, 61);
            cboTipos.Name = "cboTipos";
            cboTipos.Size = new Size(246, 23);
            cboTipos.TabIndex = 4;
            cboTipos.Visible = false;
            // 
            // btnListo
            // 
            btnListo.Location = new Point(3, 90);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(75, 23);
            btnListo.TabIndex = 3;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = true;
            btnListo.Click += btnListo_Click;
            // 
            // flpProductos
            // 
            flpProductos.Dock = DockStyle.Bottom;
            flpProductos.Location = new Point(0, 42);
            flpProductos.Name = "flpProductos";
            flpProductos.Size = new Size(800, 322);
            flpProductos.TabIndex = 5;
            // 
            // FormComprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 364);
            Controls.Add(flowLayoutPanelSeleccionFiltro);
            Controls.Add(flowLayoutPanelFiltros);
            Controls.Add(flpProductos);
            Controls.Add(btnFiltros);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "FormComprar";
            Text = "Comprar";
            flowLayoutPanelFiltros.ResumeLayout(false);
            panelCerrarFiltro.ResumeLayout(false);
            flowLayoutPanelBtnsFiltros.ResumeLayout(false);
            flowLayoutPanelSeleccionFiltro.ResumeLayout(false);
            flowLayoutPanelSeleccionFiltro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnFiltros;
        private FlowLayoutPanel flowLayoutPanelFiltros;
        private Button btnListo;
        private ComboBox cboTipos;
        private FlowLayoutPanel flpProductos;
        private Button btnPrecio;
        private Button btnTipo;
        private Button btnEstado;
        private Button btnRestablecer;
        private Panel panelCerrarFiltro;
        private Button btnCerrarFiltros;
        private FlowLayoutPanel flowLayoutPanelBtnsFiltros;
        private FlowLayoutPanel flowLayoutPanelSeleccionFiltro;
        private TextBox txtPrecioMin;
        private TextBox txtPrecioMax;
        private ComboBox cboEstado;
        private Label lblPrecioMin;
        private Label lblPrecioMax;
    }
}