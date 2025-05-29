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
            pictureBoxCerrarRegistro = new PictureBox();
            label8 = new Label();
            mtxtTelefono = new MaskedTextBox();
            btnTerminarRegistro = new Button();
            txtContraseñaRegistro = new TextBox();
            label7 = new Label();
            txtCorreoRegistro = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            flowLayoutPanelOpciones = new FlowLayoutPanel();
            groupBoxCerrarOpciones = new GroupBox();
            pictureBoxAdmin = new PictureBox();
            pictureBoxCerrarOpciones = new PictureBox();
            btnEcommerce = new Button();
            btnPreguntas = new Button();
            label9 = new Label();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxConfig).BeginInit();
            groupBoxInicioDeSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarInicioSesion).BeginInit();
            groupBoxRegristrarse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarRegistro).BeginInit();
            flowLayoutPanelOpciones.SuspendLayout();
            groupBoxCerrarOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarOpciones).BeginInit();
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
            pictureBoxConfig.Location = new Point(334, 367);
            pictureBoxConfig.Name = "pictureBoxConfig";
            pictureBoxConfig.Size = new Size(48, 25);
            pictureBoxConfig.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxConfig.TabIndex = 4;
            pictureBoxConfig.TabStop = false;
            pictureBoxConfig.Click += pictureBoxConfig_Click;
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
            groupBoxInicioDeSesion.Size = new Size(217, 132);
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
            groupBoxRegristrarse.Controls.Add(pictureBoxCerrarRegistro);
            groupBoxRegristrarse.Controls.Add(label8);
            groupBoxRegristrarse.Controls.Add(mtxtTelefono);
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
            groupBoxRegristrarse.Size = new Size(217, 211);
            groupBoxRegristrarse.TabIndex = 10;
            groupBoxRegristrarse.TabStop = false;
            groupBoxRegristrarse.Text = "Regristrate";
            groupBoxRegristrarse.Visible = false;
            // 
            // pictureBoxCerrarRegistro
            // 
            pictureBoxCerrarRegistro.Image = Properties.Resources.cerrar;
            pictureBoxCerrarRegistro.Location = new Point(192, 9);
            pictureBoxCerrarRegistro.Name = "pictureBoxCerrarRegistro";
            pictureBoxCerrarRegistro.Size = new Size(25, 25);
            pictureBoxCerrarRegistro.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarRegistro.TabIndex = 1;
            pictureBoxCerrarRegistro.TabStop = false;
            pictureBoxCerrarRegistro.Click += pictureBoxCerrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 90);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 11;
            label8.Text = "Telefono";
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Location = new Point(80, 82);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(100, 23);
            mtxtTelefono.TabIndex = 12;
            // 
            // btnTerminarRegistro
            // 
            btnTerminarRegistro.Location = new Point(68, 179);
            btnTerminarRegistro.Name = "btnTerminarRegistro";
            btnTerminarRegistro.Size = new Size(75, 23);
            btnTerminarRegistro.TabIndex = 16;
            btnTerminarRegistro.Text = "Registrarse";
            btnTerminarRegistro.UseVisualStyleBackColor = true;
            btnTerminarRegistro.Click += btnTerminarRegistro_Click;
            // 
            // txtContraseñaRegistro
            // 
            txtContraseñaRegistro.Location = new Point(80, 140);
            txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            txtContraseñaRegistro.Size = new Size(100, 23);
            txtContraseñaRegistro.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 148);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 3;
            label7.Text = "Contraseña";
            // 
            // txtCorreoRegistro
            // 
            txtCorreoRegistro.Location = new Point(80, 111);
            txtCorreoRegistro.Name = "txtCorreoRegistro";
            txtCorreoRegistro.Size = new Size(100, 23);
            txtCorreoRegistro.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 117);
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
            // flowLayoutPanelOpciones
            // 
            flowLayoutPanelOpciones.Controls.Add(groupBoxCerrarOpciones);
            flowLayoutPanelOpciones.Controls.Add(btnEcommerce);
            flowLayoutPanelOpciones.Controls.Add(btnPreguntas);
            flowLayoutPanelOpciones.Controls.Add(label9);
            flowLayoutPanelOpciones.Controls.Add(label10);
            flowLayoutPanelOpciones.Controls.Add(linkLabel1);
            flowLayoutPanelOpciones.Location = new Point(286, 203);
            flowLayoutPanelOpciones.Name = "flowLayoutPanelOpciones";
            flowLayoutPanelOpciones.Size = new Size(96, 189);
            flowLayoutPanelOpciones.TabIndex = 11;
            flowLayoutPanelOpciones.Visible = false;
            // 
            // groupBoxCerrarOpciones
            // 
            groupBoxCerrarOpciones.Controls.Add(pictureBoxAdmin);
            groupBoxCerrarOpciones.Controls.Add(pictureBoxCerrarOpciones);
            groupBoxCerrarOpciones.Location = new Point(3, 3);
            groupBoxCerrarOpciones.Name = "groupBoxCerrarOpciones";
            groupBoxCerrarOpciones.Size = new Size(93, 28);
            groupBoxCerrarOpciones.TabIndex = 2;
            groupBoxCerrarOpciones.TabStop = false;
            // 
            // pictureBoxAdmin
            // 
            pictureBoxAdmin.Image = Properties.Resources.hacker;
            pictureBoxAdmin.Location = new Point(0, 0);
            pictureBoxAdmin.Name = "pictureBoxAdmin";
            pictureBoxAdmin.Size = new Size(25, 25);
            pictureBoxAdmin.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAdmin.TabIndex = 6;
            pictureBoxAdmin.TabStop = false;
            pictureBoxAdmin.Click += pictureBoxAdmin_Click;
            // 
            // pictureBoxCerrarOpciones
            // 
            pictureBoxCerrarOpciones.Image = Properties.Resources.cerrar;
            pictureBoxCerrarOpciones.Location = new Point(68, 0);
            pictureBoxCerrarOpciones.Name = "pictureBoxCerrarOpciones";
            pictureBoxCerrarOpciones.Size = new Size(25, 25);
            pictureBoxCerrarOpciones.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCerrarOpciones.TabIndex = 0;
            pictureBoxCerrarOpciones.TabStop = false;
            pictureBoxCerrarOpciones.Click += pictureBoxCerrar_Click;
            // 
            // btnEcommerce
            // 
            btnEcommerce.Location = new Point(3, 37);
            btnEcommerce.Name = "btnEcommerce";
            btnEcommerce.Size = new Size(93, 40);
            btnEcommerce.TabIndex = 0;
            btnEcommerce.Text = "Qué es E-Commerce?";
            btnEcommerce.UseVisualStyleBackColor = true;
            btnEcommerce.Click += btnEcommerce_Click;
            // 
            // btnPreguntas
            // 
            btnPreguntas.Location = new Point(3, 83);
            btnPreguntas.Name = "btnPreguntas";
            btnPreguntas.Size = new Size(93, 40);
            btnPreguntas.TabIndex = 1;
            btnPreguntas.Text = "Preguntas frecuentes";
            btnPreguntas.UseVisualStyleBackColor = true;
            btnPreguntas.Click += btnPreguntas_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 126);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 3;
            label9.Text = "Contactanos:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 141);
            label10.Name = "label10";
            label10.Size = new Size(86, 15);
            label10.TabIndex = 4;
            label10.Text = "(505)8877-9901";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 156);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(88, 30);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "E-Commerce@gmail.com";
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 395);
            Controls.Add(flowLayoutPanelOpciones);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarRegistro).EndInit();
            flowLayoutPanelOpciones.ResumeLayout(false);
            flowLayoutPanelOpciones.PerformLayout();
            groupBoxCerrarOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCerrarOpciones).EndInit();
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
        private Label label8;
        private MaskedTextBox mtxtTelefono;
        private FlowLayoutPanel flowLayoutPanelOpciones;
        private Button btnEcommerce;
        private Button btnPreguntas;
        private GroupBox groupBoxCerrarOpciones;
        private PictureBox pictureBoxCerrarOpciones;
        private PictureBox pictureBoxCerrarRegistro;
        private Label label9;
        private Label label10;
        private LinkLabel linkLabel1;
        private PictureBox pictureBoxAdmin;
    }
}
