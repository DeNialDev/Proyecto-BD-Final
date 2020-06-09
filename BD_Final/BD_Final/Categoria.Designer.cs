namespace BD_Final
{
    partial class Categoria
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdC = new System.Windows.Forms.TextBox();
            this.txtNomC = new System.Windows.Forms.TextBox();
            this.rtxtDescC = new System.Windows.Forms.RichTextBox();
            this.bntGC = new System.Windows.Forms.Button();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnEC = new System.Windows.Forms.Button();
            this.btnBC = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 579);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la categoría: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(664, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción: ";
            // 
            // txtIdC
            // 
            this.txtIdC.Enabled = false;
            this.txtIdC.Location = new System.Drawing.Point(670, 65);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(342, 26);
            this.txtIdC.TabIndex = 4;
            // 
            // txtNomC
            // 
            this.txtNomC.Location = new System.Drawing.Point(670, 149);
            this.txtNomC.Name = "txtNomC";
            this.txtNomC.Size = new System.Drawing.Size(342, 26);
            this.txtNomC.TabIndex = 5;
            // 
            // rtxtDescC
            // 
            this.rtxtDescC.Location = new System.Drawing.Point(670, 224);
            this.rtxtDescC.Name = "rtxtDescC";
            this.rtxtDescC.Size = new System.Drawing.Size(372, 151);
            this.rtxtDescC.TabIndex = 6;
            this.rtxtDescC.Text = "";
            // 
            // bntGC
            // 
            this.bntGC.Location = new System.Drawing.Point(670, 423);
            this.bntGC.Name = "bntGC";
            this.bntGC.Size = new System.Drawing.Size(147, 41);
            this.bntGC.TabIndex = 7;
            this.bntGC.Text = "Guardar";
            this.bntGC.UseVisualStyleBackColor = true;
            this.bntGC.Click += new System.EventHandler(this.bntGC_Click);
            // 
            // btnAC
            // 
            this.btnAC.Location = new System.Drawing.Point(895, 423);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(147, 41);
            this.btnAC.TabIndex = 8;
            this.btnAC.Text = "Actualizar";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnEC
            // 
            this.btnEC.Location = new System.Drawing.Point(670, 527);
            this.btnEC.Name = "btnEC";
            this.btnEC.Size = new System.Drawing.Size(147, 41);
            this.btnEC.TabIndex = 9;
            this.btnEC.Text = "Eliminar";
            this.btnEC.UseVisualStyleBackColor = true;
            this.btnEC.Click += new System.EventHandler(this.btnEC_Click);
            // 
            // btnBC
            // 
            this.btnBC.Location = new System.Drawing.Point(895, 527);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(147, 41);
            this.btnBC.TabIndex = 10;
            this.btnBC.Text = "Buscar";
            this.btnBC.UseVisualStyleBackColor = true;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(721, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 37);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Hecho";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 603);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBC);
            this.Controls.Add(this.btnEC);
            this.Controls.Add(this.btnAC);
            this.Controls.Add(this.bntGC);
            this.Controls.Add(this.rtxtDescC);
            this.Controls.Add(this.txtNomC);
            this.Controls.Add(this.txtIdC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Categoria";
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdC;
        private System.Windows.Forms.TextBox txtNomC;
        private System.Windows.Forms.RichTextBox rtxtDescC;
        private System.Windows.Forms.Button bntGC;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnEC;
        private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Button btnBuscar;
    }
}