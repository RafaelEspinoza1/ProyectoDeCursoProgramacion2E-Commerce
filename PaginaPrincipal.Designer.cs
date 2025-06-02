namespace ProyectoDeCursoE_commerce
{
    partial class PaginaPrincipal
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnCerrar = new Button();
            btnCerrarSesion = new Button();
            btnMenu = new Button();
            tabControl1 = new TabControl();
            tabPageComprar = new TabPage();
            btnRefrescar = new Button();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1;
            label1.Text = "E-Commerce";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(btnCerrarSesion);
            flowLayoutPanel1.Location = new Point(679, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(121, 71);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCerrar);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(115, 35);
            panel2.TabIndex = 5;
            // 
            // btnCerrar
            // 
            btnCerrar.BackgroundImage = Properties.Resources.cerrar;
            btnCerrar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCerrar.Location = new Point(84, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(31, 31);
            btnCerrar.TabIndex = 14;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.AutoSize = true;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.Firebrick;
            btnCerrarSesion.Location = new Point(3, 44);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(114, 27);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackgroundImage = Properties.Resources.Menu;
            btnMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnMenu.Location = new Point(750, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 33);
            btnMenu.TabIndex = 3;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageComprar);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 43);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(814, 408);
            tabControl1.TabIndex = 4;
            // 
            // tabPageComprar
            // 
            tabPageComprar.Location = new Point(4, 24);
            tabPageComprar.Name = "tabPageComprar";
            tabPageComprar.Padding = new Padding(3);
            tabPageComprar.Size = new Size(806, 380);
            tabPageComprar.TabIndex = 0;
            tabPageComprar.Text = "Comprar";
            tabPageComprar.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackgroundImage = Properties.Resources.reinciar;
            btnRefrescar.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefrescar.Location = new Point(145, 7);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(31, 31);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(806, 380);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vender";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefrescar);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(btnMenu);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 451);
            panel1.TabIndex = 2;
            // 
            // PaginaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 451);
            Controls.Add(panel1);
            Name = "PaginaPrincipal";
            Text = "PaginaPrincipal";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCerrarSesion;
        private Button btnMenu;
        private TabControl tabControl1;
        private TabPage tabPageComprar;
        private TabPage tabPage2;
        private Panel panel1;
        private Button btnCerrar;
        private Panel panel2;
        private Button btnRefrescar;
    }
}