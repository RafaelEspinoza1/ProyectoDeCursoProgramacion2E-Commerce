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
            radioButtonNombre = new RadioButton();
            radioButtonTipo = new RadioButton();
            radioButtonPrecio = new RadioButton();
            btnListo = new Button();
            cbxBuscar = new ComboBox();
            flpProductos = new FlowLayoutPanel();
            flowLayoutPanelFiltros.SuspendLayout();
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
            flowLayoutPanelFiltros.Controls.Add(radioButtonNombre);
            flowLayoutPanelFiltros.Controls.Add(radioButtonTipo);
            flowLayoutPanelFiltros.Controls.Add(radioButtonPrecio);
            flowLayoutPanelFiltros.Controls.Add(btnListo);
            flowLayoutPanelFiltros.Location = new Point(480, 12);
            flowLayoutPanelFiltros.Name = "flowLayoutPanelFiltros";
            flowLayoutPanelFiltros.Size = new Size(148, 55);
            flowLayoutPanelFiltros.TabIndex = 3;
            flowLayoutPanelFiltros.Visible = false;
            // 
            // radioButtonNombre
            // 
            radioButtonNombre.AutoSize = true;
            radioButtonNombre.Checked = true;
            radioButtonNombre.Location = new Point(3, 3);
            radioButtonNombre.Name = "radioButtonNombre";
            radioButtonNombre.Size = new Size(69, 19);
            radioButtonNombre.TabIndex = 0;
            radioButtonNombre.TabStop = true;
            radioButtonNombre.Text = "Nombre";
            radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // radioButtonTipo
            // 
            radioButtonTipo.AutoSize = true;
            radioButtonTipo.Location = new Point(78, 3);
            radioButtonTipo.Name = "radioButtonTipo";
            radioButtonTipo.Size = new Size(49, 19);
            radioButtonTipo.TabIndex = 1;
            radioButtonTipo.Text = "Tipo";
            radioButtonTipo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPrecio
            // 
            radioButtonPrecio.AutoSize = true;
            radioButtonPrecio.Location = new Point(3, 28);
            radioButtonPrecio.Name = "radioButtonPrecio";
            radioButtonPrecio.Size = new Size(58, 19);
            radioButtonPrecio.TabIndex = 2;
            radioButtonPrecio.Text = "Precio";
            radioButtonPrecio.UseVisualStyleBackColor = true;
            // 
            // btnListo
            // 
            btnListo.Location = new Point(67, 28);
            btnListo.Name = "btnListo";
            btnListo.Size = new Size(75, 23);
            btnListo.TabIndex = 3;
            btnListo.Text = "Listo";
            btnListo.UseVisualStyleBackColor = true;
            // 
            // cbxBuscar
            // 
            cbxBuscar.FormattingEnabled = true;
            cbxBuscar.Location = new Point(93, 13);
            cbxBuscar.Name = "cbxBuscar";
            cbxBuscar.Size = new Size(121, 23);
            cbxBuscar.TabIndex = 4;
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
            Controls.Add(flowLayoutPanelFiltros);
            Controls.Add(flpProductos);
            Controls.Add(cbxBuscar);
            Controls.Add(btnFiltros);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Name = "FormComprar";
            Text = "Comprar";
            flowLayoutPanelFiltros.ResumeLayout(false);
            flowLayoutPanelFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnFiltros;
        private FlowLayoutPanel flowLayoutPanelFiltros;
        private RadioButton radioButtonNombre;
        private RadioButton radioButtonTipo;
        private RadioButton radioButtonPrecio;
        private Button btnListo;
        private ComboBox cbxBuscar;
        private FlowLayoutPanel flpProductos;
    }
}