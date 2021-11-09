﻿
namespace TPV
{
    partial class FormConsumirProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsumirProductos));
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbImpuestos = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.gbImportes = new System.Windows.Forms.GroupBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbSeleccionProductos = new System.Windows.Forms.ListBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbImportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(27, 231);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.ScrollAlwaysVisible = true;
            this.lbProductos.Size = new System.Drawing.Size(203, 212);
            this.lbProductos.TabIndex = 6;
            this.lbProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.elegirProducto);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Precio,
            this.Cantidad,
            this.Impuestos,
            this.Total});
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(27, 29);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(643, 177);
            this.dgvProductos.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Impuestos
            // 
            this.Impuestos.HeaderText = "Impuestos";
            this.Impuestos.Name = "Impuestos";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(693, 400);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(168, 43);
            this.btnAtras.TabIndex = 33;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(23, 180);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(119, 20);
            this.tbTotal.TabIndex = 34;
            this.tbTotal.Text = "€";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbImpuestos
            // 
            this.tbImpuestos.Enabled = false;
            this.tbImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImpuestos.Location = new System.Drawing.Point(23, 121);
            this.tbImpuestos.Name = "tbImpuestos";
            this.tbImpuestos.Size = new System.Drawing.Size(119, 20);
            this.tbImpuestos.TabIndex = 35;
            this.tbImpuestos.Text = "%";
            this.tbImpuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.Location = new System.Drawing.Point(23, 57);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(119, 20);
            this.tbSubtotal.TabIndex = 36;
            this.tbSubtotal.Text = "€";
            this.tbSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gbImportes
            // 
            this.gbImportes.Controls.Add(this.lblSubtotal);
            this.gbImportes.Controls.Add(this.lblImpuestos);
            this.gbImportes.Controls.Add(this.lblTotal);
            this.gbImportes.Controls.Add(this.tbSubtotal);
            this.gbImportes.Controls.Add(this.tbImpuestos);
            this.gbImportes.Controls.Add(this.tbTotal);
            this.gbImportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImportes.Location = new System.Drawing.Point(693, 29);
            this.gbImportes.Name = "gbImportes";
            this.gbImportes.Size = new System.Drawing.Size(168, 220);
            this.gbImportes.TabIndex = 37;
            this.gbImportes.TabStop = false;
            this.gbImportes.Text = "Importes";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(20, 38);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(57, 16);
            this.lblSubtotal.TabIndex = 39;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuestos.Location = new System.Drawing.Point(20, 102);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(70, 16);
            this.lblImpuestos.TabIndex = 38;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(20, 161);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 16);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "Total";
            // 
            // lbSeleccionProductos
            // 
            this.lbSeleccionProductos.FormattingEnabled = true;
            this.lbSeleccionProductos.Location = new System.Drawing.Point(281, 231);
            this.lbSeleccionProductos.Name = "lbSeleccionProductos";
            this.lbSeleccionProductos.ScrollAlwaysVisible = true;
            this.lbSeleccionProductos.Size = new System.Drawing.Size(389, 212);
            this.lbSeleccionProductos.TabIndex = 38;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Image = global::TPV.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            this.btnEliminarProducto.Location = new System.Drawing.Point(693, 265);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(168, 49);
            this.btnEliminarProducto.TabIndex = 39;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFactura.ForeColor = System.Drawing.Color.White;
            this.btnImprimirFactura.Image = global::TPV.Properties.Resources.printer_78349;
            this.btnImprimirFactura.Location = new System.Drawing.Point(693, 320);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(168, 50);
            this.btnImprimirFactura.TabIndex = 3;
            this.btnImprimirFactura.Text = "Imprimir factura";
            this.btnImprimirFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimirFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirFactura.UseVisualStyleBackColor = false;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // FormConsumirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 464);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lbSeleccionProductos);
            this.Controls.Add(this.gbImportes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnImprimirFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsumirProductos";
            this.Load += new System.EventHandler(this.FormConsumirProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbImportes.ResumeLayout(false);
            this.gbImportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbImpuestos;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.GroupBox gbImportes;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbSeleccionProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnEliminarProducto;
    }
}