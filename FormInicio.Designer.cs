namespace ProyectoDeCursoE_commerce
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            pictureBoxLogo = new PictureBox();
            btnRegistrase = new Button();
            btnIniciarSesion = new Button();
            pictureBoxConfig = new PictureBox();
            groupBoxInicioDeSesion = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            pictureBoxCerrarInicioSesion = new PictureBox();
            btnEntrar = new Button();
            toolTip1 = new ToolTip(components);
            groupBoxRegristrarse = new GroupBox();
            btnTerminarRegistro = new Button();
            txtContraseñaRegistro = new TextBox();
            label7 = new Label();
            txtCorreoRegistro = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfig).BeginInit();
            groupBoxInicioDeSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarInicioSesion).BeginInit();
            groupBoxRegristrarse.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            label1.Text = "E-Commerce";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.LogoEcommerce2;
            pictureBoxLogo.Location = new Point(134, 33);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // btnRegistrase
            // 
            btnRegistrase.Location = new Point(134, 179);
            btnRegistrase.Name = "btnRegistrase";
            btnRegistrase.Size = new Size(100, 23);
            btnRegistrase.TabIndex = 2;
            btnRegistrase.Text = "Registrase";
            btnRegistrase.UseVisualStyleBackColor = true;
            btnRegistrase.Click += btnRegistrase_Click;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(134, 150);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(100, 23);
            btnIniciarSesion.TabIndex = 3;
            btnIniciarSesion.Text = "Iniciar sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // pictureBoxConfig
            // 
            pictureBoxConfig.Image = Properties.Resources.config;
            pictureBoxConfig.Location = new Point(330, 274);
            pictureBoxConfig.Name = "pictureBoxConfig";
            pictureBoxConfig.Size = new Size(48, 25);
            pictureBoxConfig.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxConfig.TabIndex = 4;
            pictureBoxConfig.TabStop = false;
            // 
            // groupBoxInicioDeSesion
            // 
            groupBoxInicioDeSesion.Controls.Add(label3);
            groupBoxInicioDeSesion.Controls.Add(label2);
            groupBoxInicioDeSesion.Controls.Add(txtCorreo);
            groupBoxInicioDeSesion.Controls.Add(txtContraseña);
            groupBoxInicioDeSesion.Controls.Add(pictureBoxCerrarInicioSesion);
            groupBoxInicioDeSesion.Controls.Add(btnEntrar);
            groupBoxInicioDeSesion.Location = new Point(81, 150);
            groupBoxInicioDeSesion.Name = "groupBoxInicioDeSesion";
            groupBoxInicioDeSesion.Size = new Size(213, 132);
            groupBoxInicioDeSesion.TabIndex = 5;
            groupBoxInicioDeSesion.TabStop = false;
            groupBoxInicioDeSesion.Text = "Inicio de seción";
            groupBoxInicioDeSesion.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 37);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(80, 29);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(100, 23);
            txtCorreo.TabIndex = 6;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(80, 66);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(100, 23);
            txtContraseña.TabIndex = 7;
            // 
            // pictureBoxCerrarInicioSesion
            // 
            pictureBoxCerrarInicioSesion.Image = Properties.Resources.cerrar;
            pictureBoxCerrarInicioSesion.Location = new Point(188, 9);
            pictureBoxCerrarInicioSesion.Name = "pictureBoxCerrarInicioSesion";
            pictureBoxCerrarInicioSesion.Size = new Size(25, 25);
            pictureBoxCerrarInicioSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarInicioSesion.TabIndex = 1;
            pictureBoxCerrarInicioSesion.TabStop = false;
            pictureBoxCerrarInicioSesion.Click += pictureBoxCerrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(68, 103);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // groupBoxRegristrarse
            // 
            groupBoxRegristrarse.Controls.Add(btnTerminarRegistro);
            groupBoxRegristrarse.Controls.Add(txtContraseñaRegistro);
            groupBoxRegristrarse.Controls.Add(label7);
            groupBoxRegristrarse.Controls.Add(txtCorreoRegistro);
            groupBoxRegristrarse.Controls.Add(label6);
            groupBoxRegristrarse.Controls.Add(txtApellido);
            groupBoxRegristrarse.Controls.Add(txtNombre);
            groupBoxRegristrarse.Controls.Add(label5);
            groupBoxRegristrarse.Controls.Add(label4);
            groupBoxRegristrarse.Location = new Point(81, 150);
            groupBoxRegristrarse.Name = "groupBoxRegristrarse";
            groupBoxRegristrarse.Size = new Size(213, 176);
            groupBoxRegristrarse.TabIndex = 10;
            groupBoxRegristrarse.TabStop = false;
            groupBoxRegristrarse.Text = "Regristrate";
            groupBoxRegristrarse.Visible = false;
            // 
            // btnTerminarRegistro
            // 
            btnTerminarRegistro.Location = new Point(68, 139);
            btnTerminarRegistro.Name = "btnTerminarRegistro";
            btnTerminarRegistro.Size = new Size(75, 23);
            btnTerminarRegistro.TabIndex = 16;
            btnTerminarRegistro.Text = "Registrarse";
            btnTerminarRegistro.UseVisualStyleBackColor = true;
            btnTerminarRegistro.Click += btnTerminarRegistro_Click;
            // 
            // txtContraseñaRegistro
            // 
            txtContraseñaRegistro.Location = new Point(79, 111);
            txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            txtContraseñaRegistro.Size = new Size(100, 23);
            txtContraseñaRegistro.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 119);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 3;
            label7.Text = "Contraseña";
            // 
            // txtCorreoRegistro
            // 
            txtCorreoRegistro.Location = new Point(80, 81);
            txtCorreoRegistro.Name = "txtCorreoRegistro";
            txtCorreoRegistro.Size = new Size(100, 23);
            txtCorreoRegistro.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 90);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 2;
            label6.Text = "Correo";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(80, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 61);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 32);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Nombre";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 341);
            Controls.Add(groupBoxRegristrarse);
            Controls.Add(label1);
            Controls.Add(groupBoxInicioDeSesion);
            Controls.Add(pictureBoxConfig);
            Controls.Add(btnIniciarSesion);
            Controls.Add(btnRegistrase);
            Controls.Add(pictureBoxLogo);
            Name = "FormInicio";
            Text = "Incio de sesión";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfig).EndInit();
            groupBoxInicioDeSesion.ResumeLayout(false);
            groupBoxInicioDeSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarInicioSesion).EndInit();
            groupBoxRegristrarse.ResumeLayout(false);
            groupBoxRegristrarse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxLogo;
        private Button btnRegistrase;
        private Button btnIniciarSesion;
        private PictureBox pictureBoxConfig;
        private GroupBox groupBoxInicioDeSesion;
        private Button btnEntrar;
        private PictureBox pictureBoxCerrarInicioSesion;
        private Label label3;
        private Label label2;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private ToolTip toolTip1;
        private GroupBox groupBoxRegristrarse;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtContraseñaRegistro;
        private TextBox txtCorreoRegistro;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnTerminarRegistro;
    }
}
