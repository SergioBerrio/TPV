
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
            this.btnConsumir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.gbImportes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbImpuestos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSeleccionProductos = new System.Windows.Forms.ListBox();
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
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Enabled = false;
            this.dgvProductos.Location = new System.Drawing.Point(27, 29);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(544, 177);
            this.dgvProductos.TabIndex = 7;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumir.Location = new System.Drawing.Point(602, 329);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(168, 48);
            this.btnConsumir.TabIndex = 2;
            this.btnConsumir.Text = "Consumir productos";
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(602, 408);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(168, 35);
            this.btnAtras.TabIndex = 33;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::TPV.Properties.Resources.printer_78349;
            this.btnImprimir.Location = new System.Drawing.Point(602, 275);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(168, 48);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir factura";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(23, 180);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(119, 20);
            this.tbTotal.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(23, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 35;
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubtotal.Location = new System.Drawing.Point(23, 57);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(119, 20);
            this.tbSubtotal.TabIndex = 36;
            // 
            // gbImportes
            // 
            this.gbImportes.Controls.Add(this.label3);
            this.gbImportes.Controls.Add(this.tbImpuestos);
            this.gbImportes.Controls.Add(this.label1);
            this.gbImportes.Controls.Add(this.tbSubtotal);
            this.gbImportes.Controls.Add(this.textBox2);
            this.gbImportes.Controls.Add(this.tbTotal);
            this.gbImportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImportes.Location = new System.Drawing.Point(602, 29);
            this.gbImportes.Name = "gbImportes";
            this.gbImportes.Size = new System.Drawing.Size(168, 220);
            this.gbImportes.TabIndex = 37;
            this.gbImportes.TabStop = false;
            this.gbImportes.Text = "Importes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Total";
            // 
            // tbImpuestos
            // 
            this.tbImpuestos.AutoSize = true;
            this.tbImpuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImpuestos.Location = new System.Drawing.Point(20, 102);
            this.tbImpuestos.Name = "tbImpuestos";
            this.tbImpuestos.Size = new System.Drawing.Size(70, 16);
            this.tbImpuestos.TabIndex = 38;
            this.tbImpuestos.Text = "Impuestos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Subtotal";
            // 
            // lbSeleccionProductos
            // 
            this.lbSeleccionProductos.FormattingEnabled = true;
            this.lbSeleccionProductos.Location = new System.Drawing.Point(277, 231);
            this.lbSeleccionProductos.Name = "lbSeleccionProductos";
            this.lbSeleccionProductos.ScrollAlwaysVisible = true;
            this.lbSeleccionProductos.Size = new System.Drawing.Size(268, 212);
            this.lbSeleccionProductos.TabIndex = 38;
            // 
            // FormConsumirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 464);
            this.Controls.Add(this.lbSeleccionProductos);
            this.Controls.Add(this.gbImportes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnConsumir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsumirProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsumirProductos";
            this.Load += new System.EventHandler(this.FormConsumirProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbImportes.ResumeLayout(false);
            this.gbImportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.GroupBox gbImportes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tbImpuestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbSeleccionProductos;
    }
}