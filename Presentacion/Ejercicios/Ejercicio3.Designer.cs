namespace CursoClase1Csharp.Ejercicios
{
    partial class Ejercicio3
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResIMC = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalcularIMC = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblIMC = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultadoIMC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEjercicio3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResIMC
            // 
            this.lblResIMC.AutoSize = true;
            this.lblResIMC.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResIMC.ForeColor = System.Drawing.Color.White;
            this.lblResIMC.Location = new System.Drawing.Point(90, 196);
            this.lblResIMC.Name = "lblResIMC";
            this.lblResIMC.Size = new System.Drawing.Size(130, 22);
            this.lblResIMC.TabIndex = 20;
            this.lblResIMC.Text = "Usted esta: \r\n";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.ForeColor = System.Drawing.Color.White;
            this.lblArea.Location = new System.Drawing.Point(72, 93);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(80, 22);
            this.lblArea.TabIndex = 18;
            this.lblArea.Text = "Altura:";
            // 
            // btnCalcularIMC
            // 
            this.btnCalcularIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnCalcularIMC.FlatAppearance.BorderSize = 0;
            this.btnCalcularIMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularIMC.Location = new System.Drawing.Point(345, 68);
            this.btnCalcularIMC.Name = "btnCalcularIMC";
            this.btnCalcularIMC.Size = new System.Drawing.Size(160, 60);
            this.btnCalcularIMC.TabIndex = 17;
            this.btnCalcularIMC.Text = "Calcular";
            this.btnCalcularIMC.UseVisualStyleBackColor = false;
            this.btnCalcularIMC.Click += new System.EventHandler(this.btnCalcularIMC_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(148, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 2);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(148, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(148, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 2);
            this.panel2.TabIndex = 16;
            // 
            // txtIMC
            // 
            this.txtIMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txtIMC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIMC.ForeColor = System.Drawing.Color.White;
            this.txtIMC.Location = new System.Drawing.Point(148, 134);
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.Size = new System.Drawing.Size(125, 22);
            this.txtIMC.TabIndex = 11;
            // 
            // txtaltura
            // 
            this.txtaltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaltura.ForeColor = System.Drawing.Color.White;
            this.txtaltura.Location = new System.Drawing.Point(158, 87);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(125, 22);
            this.txtaltura.TabIndex = 12;
            // 
            // txtpeso
            // 
            this.txtpeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.ForeColor = System.Drawing.Color.White;
            this.txtpeso.Location = new System.Drawing.Point(148, 32);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(125, 22);
            this.txtpeso.TabIndex = 13;
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.ForeColor = System.Drawing.Color.White;
            this.lblIMC.Location = new System.Drawing.Point(72, 140);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(50, 22);
            this.lblIMC.TabIndex = 9;
            this.lblIMC.Text = "IMC:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(72, 38);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(60, 22);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblresultadoIMC);
            this.panel1.Controls.Add(this.lblResIMC);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.btnCalcularIMC);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtIMC);
            this.panel1.Controls.Add(this.txtaltura);
            this.panel1.Controls.Add(this.txtpeso);
            this.panel1.Controls.Add(this.lblIMC);
            this.panel1.Controls.Add(this.lblPeso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 232);
            this.panel1.TabIndex = 7;
            // 
            // lblresultadoIMC
            // 
            this.lblresultadoIMC.AutoSize = true;
            this.lblresultadoIMC.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultadoIMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblresultadoIMC.Location = new System.Drawing.Point(226, 196);
            this.lblresultadoIMC.Name = "lblresultadoIMC";
            this.lblresultadoIMC.Size = new System.Drawing.Size(20, 22);
            this.lblresultadoIMC.TabIndex = 19;
            this.lblresultadoIMC.Text = "-\r\n";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(0, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Solucion:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEjercicio3
            // 
            this.lblEjercicio3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.lblEjercicio3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEjercicio3.Font = new System.Drawing.Font("Consolas", 16F);
            this.lblEjercicio3.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio3.Name = "lblEjercicio3";
            this.lblEjercicio3.Size = new System.Drawing.Size(937, 55);
            this.lblEjercicio3.TabIndex = 4;
            this.lblEjercicio3.Text = "Ejercicio 3";
            this.lblEjercicio3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoClase1Csharp.Properties.Resources.Ejercicio_3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEjercicio3);
            this.Name = "Ejercicio3";
            this.Size = new System.Drawing.Size(937, 571);
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblResIMC;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalcularIMC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEjercicio3;
        private System.Windows.Forms.Label lblresultadoIMC;
    }
}
