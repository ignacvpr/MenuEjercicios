namespace CursoClase1Csharp.Ejercicios
{
    partial class Ejercicio1
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
            this.lblEjercicio1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.opC = new System.Windows.Forms.Label();
            this.opB = new System.Windows.Forms.Label();
            this.opA = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEjercicio1
            // 
            this.lblEjercicio1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEjercicio1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio1.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio1.Name = "lblEjercicio1";
            this.lblEjercicio1.Size = new System.Drawing.Size(797, 78);
            this.lblEjercicio1.TabIndex = 0;
            this.lblEjercicio1.Text = "Ejercicio 1";
            this.lblEjercicio1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.label2.Location = new System.Drawing.Point(0, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solucion:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblresultado);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtc);
            this.panel1.Controls.Add(this.txtb);
            this.panel1.Controls.Add(this.txta);
            this.panel1.Controls.Add(this.opC);
            this.panel1.Controls.Add(this.opB);
            this.panel1.Controls.Add(this.opA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 264);
            this.panel1.TabIndex = 3;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblresultado.Location = new System.Drawing.Point(158, 183);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(20, 22);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(291, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(160, 60);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(94, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 2);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(94, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(94, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 2);
            this.panel2.TabIndex = 6;
            // 
            // txtc
            // 
            this.txtc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txtc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtc.ForeColor = System.Drawing.Color.White;
            this.txtc.Location = new System.Drawing.Point(94, 128);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(125, 22);
            this.txtc.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.ForeColor = System.Drawing.Color.White;
            this.txtb.Location = new System.Drawing.Point(94, 81);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(125, 22);
            this.txtb.TabIndex = 5;
            // 
            // txta
            // 
            this.txta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.txta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txta.ForeColor = System.Drawing.Color.White;
            this.txta.Location = new System.Drawing.Point(94, 26);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(125, 22);
            this.txta.TabIndex = 5;
            // 
            // opC
            // 
            this.opC.AutoSize = true;
            this.opC.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opC.ForeColor = System.Drawing.Color.White;
            this.opC.Location = new System.Drawing.Point(37, 130);
            this.opC.Name = "opC";
            this.opC.Size = new System.Drawing.Size(30, 22);
            this.opC.TabIndex = 4;
            this.opC.Text = "c:";
            // 
            // opB
            // 
            this.opB.AutoSize = true;
            this.opB.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opB.ForeColor = System.Drawing.Color.White;
            this.opB.Location = new System.Drawing.Point(37, 83);
            this.opB.Name = "opB";
            this.opB.Size = new System.Drawing.Size(30, 22);
            this.opB.TabIndex = 4;
            this.opB.Text = "b:";
            // 
            // opA
            // 
            this.opA.AutoSize = true;
            this.opA.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opA.ForeColor = System.Drawing.Color.White;
            this.opA.Location = new System.Drawing.Point(37, 32);
            this.opA.Name = "opA";
            this.opA.Size = new System.Drawing.Size(30, 22);
            this.opA.TabIndex = 3;
            this.opA.Text = "a:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::CursoClase1Csharp.Properties.Resources.Ejercicio1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(85)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEjercicio1);
            this.Name = "Ejercicio1";
            this.Size = new System.Drawing.Size(797, 548);
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label opC;
        private System.Windows.Forms.Label opB;
        private System.Windows.Forms.Label opA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label3;
    }
}
