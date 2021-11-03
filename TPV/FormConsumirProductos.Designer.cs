
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAbajo1 = new System.Windows.Forms.Button();
            this.btnArriba1 = new System.Windows.Forms.Button();
            this.btnAbajo2 = new System.Windows.Forms.Button();
            this.btnArriba2 = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(340, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(426, 147);
            this.listBox1.TabIndex = 1;
            // 
            // btnAbajo1
            // 
            this.btnAbajo1.Location = new System.Drawing.Point(581, 119);
            this.btnAbajo1.Name = "btnAbajo1";
            this.btnAbajo1.Size = new System.Drawing.Size(66, 51);
            this.btnAbajo1.TabIndex = 5;
            this.btnAbajo1.UseVisualStyleBackColor = true;
            this.btnAbajo1.Click += new System.EventHandler(this.btnAbajo1_Click);
            // 
            // btnArriba1
            // 
            this.btnArriba1.Location = new System.Drawing.Point(581, 43);
            this.btnArriba1.Name = "btnArriba1";
            this.btnArriba1.Size = new System.Drawing.Size(66, 51);
            this.btnArriba1.TabIndex = 4;
            this.btnArriba1.UseVisualStyleBackColor = true;
            this.btnArriba1.Click += new System.EventHandler(this.btnArriba1_Click);
            // 
            // btnAbajo2
            // 
            this.btnAbajo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbajo2.Location = new System.Drawing.Point(253, 372);
            this.btnAbajo2.Name = "btnAbajo2";
            this.btnAbajo2.Size = new System.Drawing.Size(66, 57);
            this.btnAbajo2.TabIndex = 3;
            this.btnAbajo2.UseVisualStyleBackColor = true;
            this.btnAbajo2.Click += new System.EventHandler(this.btnAbajo2_Click);
            // 
            // btnArriba2
            // 
            this.btnArriba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArriba2.Location = new System.Drawing.Point(253, 282);
            this.btnArriba2.Name = "btnArriba2";
            this.btnArriba2.Size = new System.Drawing.Size(66, 58);
            this.btnArriba2.TabIndex = 2;
            this.btnArriba2.UseVisualStyleBackColor = true;
            this.btnArriba2.Click += new System.EventHandler(this.btnArriba2_Click);
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(27, 277);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(203, 147);
            this.lbProductos.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 221);
            this.dataGridView1.TabIndex = 7;
            // 
            // FormConsumirProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.btnAbajo1);
            this.Controls.Add(this.btnArriba1);
            this.Controls.Add(this.btnAbajo2);
            this.Controls.Add(this.btnArriba2);
            this.Controls.Add(this.listBox1);
            this.Name = "FormConsumirProductos";
            this.Text = "FormConsumirProductos";
            this.Load += new System.EventHandler(this.FormConsumirProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnArriba2;
        private System.Windows.Forms.Button btnAbajo2;
        private System.Windows.Forms.Button btnAbajo1;
        private System.Windows.Forms.Button btnArriba1;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}