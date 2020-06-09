namespace BD_Final
{
    partial class Subcategoria
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
            this.btnADatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdS = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bntGS = new System.Windows.Forms.Button();
            this.btnAS = new System.Windows.Forms.Button();
            this.btnES = new System.Windows.Forms.Button();
            this.btnBS = new System.Windows.Forms.Button();
            this.txtNomS = new System.Windows.Forms.TextBox();
            this.txtIdC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(402, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnADatos
            // 
            this.btnADatos.Location = new System.Drawing.Point(8, 8);
            this.btnADatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADatos.Name = "btnADatos";
            this.btnADatos.Size = new System.Drawing.Size(122, 22);
            this.btnADatos.TabIndex = 2;
            this.btnADatos.Text = "Actualizar datos";
            this.btnADatos.UseVisualStyleBackColor = true;
            this.btnADatos.Click += new System.EventHandler(this.btnADatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id: ";
            // 
            // txtIdS
            // 
            this.txtIdS.Enabled = false;
            this.txtIdS.Location = new System.Drawing.Point(433, 58);
            this.txtIdS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdS.Name = "txtIdS";
            this.txtIdS.Size = new System.Drawing.Size(229, 20);
            this.txtIdS.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(467, 30);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 24);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Hecho";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Id de categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre de subcategoría:";
            // 
            // bntGS
            // 
            this.bntGS.Location = new System.Drawing.Point(433, 229);
            this.bntGS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntGS.Name = "bntGS";
            this.bntGS.Size = new System.Drawing.Size(98, 27);
            this.bntGS.TabIndex = 17;
            this.bntGS.Text = "Guardar";
            this.bntGS.UseVisualStyleBackColor = true;
            this.bntGS.Click += new System.EventHandler(this.bntGS_Click);
            // 
            // btnAS
            // 
            this.btnAS.Location = new System.Drawing.Point(563, 229);
            this.btnAS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(98, 27);
            this.btnAS.TabIndex = 18;
            this.btnAS.Text = "Actualizar";
            this.btnAS.UseVisualStyleBackColor = true;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // btnES
            // 
            this.btnES.Location = new System.Drawing.Point(433, 291);
            this.btnES.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnES.Name = "btnES";
            this.btnES.Size = new System.Drawing.Size(98, 27);
            this.btnES.TabIndex = 19;
            this.btnES.Text = "Eliminar";
            this.btnES.UseVisualStyleBackColor = true;
            this.btnES.Click += new System.EventHandler(this.btnES_Click);
            // 
            // btnBS
            // 
            this.btnBS.Location = new System.Drawing.Point(563, 291);
            this.btnBS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(98, 27);
            this.btnBS.TabIndex = 20;
            this.btnBS.Text = "Buscar";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // txtNomS
            // 
            this.txtNomS.Location = new System.Drawing.Point(433, 163);
            this.txtNomS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomS.Name = "txtNomS";
            this.txtNomS.Size = new System.Drawing.Size(229, 20);
            this.txtNomS.TabIndex = 21;
            // 
            // txtIdC
            // 
            this.txtIdC.Location = new System.Drawing.Point(433, 113);
            this.txtIdC.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdC.Name = "txtIdC";
            this.txtIdC.Size = new System.Drawing.Size(229, 20);
            this.txtIdC.TabIndex = 14;
            // 
            // Subcategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 389);
            this.Controls.Add(this.txtNomS);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.btnES);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.bntGS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnADatos);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Subcategoria";
            this.Text = "Subcategoria";
            this.Load += new System.EventHandler(this.Subcategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnADatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdS;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bntGS;
        private System.Windows.Forms.Button btnAS;
        private System.Windows.Forms.Button btnES;
        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.TextBox txtNomS;
        private System.Windows.Forms.TextBox txtIdC;
    }
}