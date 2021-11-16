
namespace TPV
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lbUsuarios = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbContrasenaModificar = new System.Windows.Forms.TextBox();
            this.tbUsuarioModificar = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = global::TPV.Properties.Resources.edit_icon_icons_com_66118;
            this.btnModificar.Location = new System.Drawing.Point(30, 170);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(191, 49);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Image = global::TPV.Properties.Resources.emblemnew_93501;
            this.btnAnadir.Location = new System.Drawing.Point(32, 170);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(176, 49);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // tbContrasena
            // 
            this.tbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasena.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbContrasena.Location = new System.Drawing.Point(32, 85);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(176, 20);
            this.tbContrasena.TabIndex = 2;
            this.tbContrasena.Text = "Introduce la contraseña";
            this.tbContrasena.Enter += new System.EventHandler(this.cambiarTextoContrasena);
            this.tbContrasena.Leave += new System.EventHandler(this.cambiarTextoContrasenaSalir);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsuario.Location = new System.Drawing.Point(32, 49);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(176, 20);
            this.tbUsuario.TabIndex = 1;
            this.tbUsuario.Text = "Introduce el usuario";
            this.tbUsuario.Enter += new System.EventHandler(this.cambiarTextoUsuario);
            this.tbUsuario.Leave += new System.EventHandler(this.cambiarTextoUsuarioSalir);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(604, 360);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 29);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.FormattingEnabled = true;
            this.lbUsuarios.ItemHeight = 18;
            this.lbUsuarios.Location = new System.Drawing.Point(22, 64);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.ScrollAlwaysVisible = true;
            this.lbUsuarios.Size = new System.Drawing.Size(132, 274);
            this.lbUsuarios.TabIndex = 14;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::TPV.Properties.Resources.seo_social_web_network_internet_262_icon_icons_com_61518;
            this.btnEliminar.Location = new System.Drawing.Point(33, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(176, 49);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAdmin);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.tbContrasena);
            this.groupBox1.Controls.Add(this.tbUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(217, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 238);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir usuario";
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdmin.Location = new System.Drawing.Point(32, 129);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(70, 17);
            this.cbAdmin.TabIndex = 3;
            this.cbAdmin.Text = "Es Admin";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbContrasenaModificar);
            this.groupBox2.Controls.Add(this.tbUsuarioModificar);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(474, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 238);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar usuario";
            // 
            // tbContrasenaModificar
            // 
            this.tbContrasenaModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenaModificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbContrasenaModificar.Location = new System.Drawing.Point(30, 85);
            this.tbContrasenaModificar.Name = "tbContrasenaModificar";
            this.tbContrasenaModificar.Size = new System.Drawing.Size(176, 20);
            this.tbContrasenaModificar.TabIndex = 11;
            this.tbContrasenaModificar.Text = "Introduce la contraseña";
            this.tbContrasenaModificar.Enter += new System.EventHandler(this.cambiarTextoContrasenaModificar);
            this.tbContrasenaModificar.Leave += new System.EventHandler(this.cambiarTextoContrasenaModificarSalir);
            // 
            // tbUsuarioModificar
            // 
            this.tbUsuarioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuarioModificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbUsuarioModificar.Location = new System.Drawing.Point(30, 49);
            this.tbUsuarioModificar.Name = "tbUsuarioModificar";
            this.tbUsuarioModificar.Size = new System.Drawing.Size(176, 20);
            this.tbUsuarioModificar.TabIndex = 10;
            this.tbUsuarioModificar.Text = "Introduce el usuario";
            this.tbUsuarioModificar.Enter += new System.EventHandler(this.cambiarTextoUsuarioModificar);
            this.tbUsuarioModificar.Leave += new System.EventHandler(this.cambiarTextoUsuarioModificarSalir);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(30, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Es Admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(216, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 110);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar usuario";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbUsuarios);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(15, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 363);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lista de usuarios";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 413);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.cargarForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lbUsuarios;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbContrasenaModificar;
        private System.Windows.Forms.TextBox tbUsuarioModificar;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}