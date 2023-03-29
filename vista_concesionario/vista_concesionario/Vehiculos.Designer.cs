namespace vista_concesionario
{
    partial class Vehiculos
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
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.placa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridVehiculos = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.ctrlBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(91, 83);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(135, 26);
            this.txtPlaca.TabIndex = 13;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(91, 357);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(135, 26);
            this.txtPrecio.TabIndex = 14;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 289);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(135, 26);
            this.txtMarca.TabIndex = 15;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(91, 218);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(135, 26);
            this.txtColor.TabIndex = 16;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(91, 149);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(135, 26);
            this.txtModelo.TabIndex = 17;
            // 
            // placa
            // 
            this.placa.AutoSize = true;
            this.placa.Location = new System.Drawing.Point(101, 60);
            this.placa.Name = "placa";
            this.placa.Size = new System.Drawing.Size(48, 20);
            this.placa.TabIndex = 18;
            this.placa.Text = "Placa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio";
            // 
            // dataGridVehiculos
            // 
            this.dataGridVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVehiculos.Location = new System.Drawing.Point(308, 83);
            this.dataGridVehiculos.Name = "dataGridVehiculos";
            this.dataGridVehiculos.RowHeadersWidth = 62;
            this.dataGridVehiculos.RowTemplate.Height = 28;
            this.dataGridVehiculos.Size = new System.Drawing.Size(402, 232);
            this.dataGridVehiculos.TabIndex = 23;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(598, 347);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(96, 43);
            this.btnProcess.TabIndex = 24;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ctrlBox
            // 
            this.ctrlBox.FormattingEnabled = true;
            this.ctrlBox.Items.AddRange(new object[] {
            "Guardar",
            "Actualizar",
            "Eliminar",
            "Consultar",
            "Listar"});
            this.ctrlBox.Location = new System.Drawing.Point(324, 355);
            this.ctrlBox.Name = "ctrlBox";
            this.ctrlBox.Size = new System.Drawing.Size(157, 28);
            this.ctrlBox.TabIndex = 25;
            // 
            // Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.ctrlBox);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.dataGridVehiculos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placa);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtPlaca);
            this.Name = "Vehiculos";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vehiculos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label placa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridVehiculos;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ComboBox ctrlBox;
    }
}