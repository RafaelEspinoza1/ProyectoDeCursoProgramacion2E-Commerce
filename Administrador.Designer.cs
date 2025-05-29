namespace ProyectoDeCursoE_commerce
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            lblContraseña1 = new Label();
            txtContraseña1 = new TextBox();
            btnContraseña1 = new Button();
            groupBoxIngresar = new GroupBox();
            btnIngresar = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBoxIngresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblContraseña1
            // 
            lblContraseña1.AutoSize = true;
            lblContraseña1.Location = new Point(105, 9);
            lblContraseña1.Name = "lblContraseña1";
            lblContraseña1.Size = new Size(67, 15);
            lblContraseña1.TabIndex = 0;
            lblContraseña1.Text = "Contraseña";
            // 
            // txtContraseña1
            // 
            txtContraseña1.Location = new Point(92, 27);
            txtContraseña1.Name = "txtContraseña1";
            txtContraseña1.Size = new Size(100, 23);
            txtContraseña1.TabIndex = 1;
            // 
            // btnContraseña1
            // 
            btnContraseña1.Location = new Point(105, 56);
            btnContraseña1.Name = "btnContraseña1";
            btnContraseña1.Size = new Size(75, 23);
            btnContraseña1.TabIndex = 2;
            btnContraseña1.Text = "Ingresar";
            btnContraseña1.UseVisualStyleBackColor = true;
            btnContraseña1.Click += btnContraseña1_Click;
            // 
            // groupBoxIngresar
            // 
            groupBoxIngresar.Controls.Add(btnIngresar);
            groupBoxIngresar.Controls.Add(textBox2);
            groupBoxIngresar.Controls.Add(textBox1);
            groupBoxIngresar.Controls.Add(label2);
            groupBoxIngresar.Controls.Add(label1);
            groupBoxIngresar.Location = new Point(12, 9);
            groupBoxIngresar.Name = "groupBoxIngresar";
            groupBoxIngresar.Size = new Size(226, 100);
            groupBoxIngresar.TabIndex = 3;
            groupBoxIngresar.TabStop = false;
            groupBoxIngresar.Text = "Admin";
            groupBoxIngresar.Visible = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(78, 71);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 48);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Correo del admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cerrar;
            pictureBox1.Location = new Point(255, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBoxCerrar_Click;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 129);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxIngresar);
            Controls.Add(btnContraseña1);
            Controls.Add(txtContraseña1);
            Controls.Add(lblContraseña1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administrador";
            Text = "Administrador";
            groupBoxIngresar.ResumeLayout(false);
            groupBoxIngresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContraseña1;
        private TextBox txtContraseña1;
        private Button btnContraseña1;
        private GroupBox groupBoxIngresar;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button btnIngresar;
        private PictureBox pictureBox1;
    }
}