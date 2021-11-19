
namespace TPV
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnAlmacen = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlmacen
            // 
            this.btnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacen.Image = ((System.Drawing.Image)(resources.GetObject("btnAlmacen.Image")));
            this.btnAlmacen.Location = new System.Drawing.Point(38, 121);
            this.btnAlmacen.Name = "btnAlmacen";
            this.btnAlmacen.Size = new System.Drawing.Size(204, 147);
            this.btnAlmacen.TabIndex = 0;
            this.btnAlmacen.Text = "Acceso al stock de almacén";
            this.btnAlmacen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlmacen.UseVisualStyleBackColor = true;
            this.btnAlmacen.Click += new System.EventHandler(this.btnAlmacen_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(74, 49);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(389, 33);
            this.lblAdmin.TabIndex = 2;
            this.lblAdmin.Text = "Panel de control del Admin";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(287, 121);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(204, 147);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Acceso a los usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarSesión.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesión.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesión.Image")));
            this.btnCerrarSesión.Location = new System.Drawing.Point(155, 302);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(201, 57);
            this.btnCerrarSesión.TabIndex = 9;
            this.btnCerrarSesión.Text = "Cerrar sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 387);
            this.Controls.Add(this.btnCerrarSesión);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnAlmacen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel del Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarAplicacion);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlmacen;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnCerrarSesión;
    }
}