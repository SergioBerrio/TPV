﻿
namespace TPV
{
    partial class FormAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlmacen));
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCantidadModificar = new System.Windows.Forms.TextBox();
            this.tbPrecioModificar = new System.Windows.Forms.TextBox();
            this.tbProductoModificar = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(21, 29);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(146, 342);
            this.lbProductos.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(192, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 93);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(32, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(176, 29);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCantidadModificar);
            this.groupBox2.Controls.Add(this.tbPrecioModificar);
            this.groupBox2.Controls.Add(this.tbProductoModificar);
            this.groupBox2.Controls.Add(this.btnModificar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(471, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 221);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar producto";
            // 
            // tbCantidadModificar
            // 
            this.tbCantidadModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidadModificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCantidadModificar.Location = new System.Drawing.Point(30, 128);
            this.tbCantidadModificar.Name = "tbCantidadModificar";
            this.tbCantidadModificar.Size = new System.Drawing.Size(176, 20);
            this.tbCantidadModificar.TabIndex = 6;
            this.tbCantidadModificar.Text = "Introduce la cantidad";
            this.tbCantidadModificar.Enter += new System.EventHandler(this.cambiarTextoCantidadModificar);
            this.tbCantidadModificar.Leave += new System.EventHandler(this.cambiarTextoCantidadModificarSalir);
            // 
            // tbPrecioModificar
            // 
            this.tbPrecioModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioModificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrecioModificar.Location = new System.Drawing.Point(30, 85);
            this.tbPrecioModificar.Name = "tbPrecioModificar";
            this.tbPrecioModificar.Size = new System.Drawing.Size(176, 20);
            this.tbPrecioModificar.TabIndex = 11;
            this.tbPrecioModificar.Text = "Introduce el precio";
            this.tbPrecioModificar.Enter += new System.EventHandler(this.cambiarTextoPrecioModificar);
            this.tbPrecioModificar.Leave += new System.EventHandler(this.cambiarTextoPrecioModificarSalir);
            // 
            // tbProductoModificar
            // 
            this.tbProductoModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductoModificar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbProductoModificar.Location = new System.Drawing.Point(30, 49);
            this.tbProductoModificar.Name = "tbProductoModificar";
            this.tbProductoModificar.Size = new System.Drawing.Size(176, 20);
            this.tbProductoModificar.TabIndex = 10;
            this.tbProductoModificar.Text = "Introduce el producto";
            this.tbProductoModificar.Enter += new System.EventHandler(this.cambiarTextoProductoModificar);
            this.tbProductoModificar.Leave += new System.EventHandler(this.cambiarTextoProductoModificarSalir);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(30, 170);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(191, 29);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCantidad);
            this.groupBox1.Controls.Add(this.btnAnadir);
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.tbProducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(192, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 221);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Añadir producto";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCantidad.Location = new System.Drawing.Point(32, 128);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(176, 20);
            this.tbCantidad.TabIndex = 3;
            this.tbCantidad.Text = "Introduce la cantidad";
            this.tbCantidad.Enter += new System.EventHandler(this.cambiarTextoCantidad);
            this.tbCantidad.Leave += new System.EventHandler(this.cambiarTextoCantidadSalir);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.Location = new System.Drawing.Point(32, 170);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(176, 29);
            this.btnAnadir.TabIndex = 4;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPrecio.Location = new System.Drawing.Point(32, 85);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(176, 20);
            this.tbPrecio.TabIndex = 2;
            this.tbPrecio.Text = "Introduce el precio";
            this.tbPrecio.Enter += new System.EventHandler(this.cambiarTextoPrecio);
            this.tbPrecio.Leave += new System.EventHandler(this.cambiarTextoPrecioSalir);
            // 
            // tbProducto
            // 
            this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbProducto.Location = new System.Drawing.Point(32, 49);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(176, 20);
            this.tbProducto.TabIndex = 1;
            this.tbProducto.Text = "Introduce el producto";
            this.tbProducto.Enter += new System.EventHandler(this.cambiarTextoProducto);
            this.tbProducto.Leave += new System.EventHandler(this.cambiarTextoProductoSalir);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(601, 342);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(112, 29);
            this.btnAtras.TabIndex = 32;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_2);
            // 
            // FormAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lbProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlmacen";
            this.Load += new System.EventHandler(this.FormAlmacen_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCantidadModificar;
        private System.Windows.Forms.TextBox tbPrecioModificar;
        private System.Windows.Forms.TextBox tbProductoModificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.Button btnAtras;
    }
}