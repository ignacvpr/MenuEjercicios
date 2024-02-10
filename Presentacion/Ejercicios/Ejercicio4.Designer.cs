namespace CursoClase1Csharp.Ejercicios
{
    partial class Ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTalle = new System.Windows.Forms.GroupBox();
            this.rbTalleL = new System.Windows.Forms.RadioButton();
            this.rbTalleM = new System.Windows.Forms.RadioButton();
            this.rbTalleS = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.rbNegro = new System.Windows.Forms.RadioButton();
            this.rbBlanco = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtboxTalle = new System.Windows.Forms.TextBox();
            this.txtboxcolor = new System.Windows.Forms.TextBox();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBoxTalle.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(927, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remeras Basics";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxTalle
            // 
            this.groupBoxTalle.Controls.Add(this.rbTalleL);
            this.groupBoxTalle.Controls.Add(this.rbTalleM);
            this.groupBoxTalle.Controls.Add(this.rbTalleS);
            this.groupBoxTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxTalle.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.groupBoxTalle.Location = new System.Drawing.Point(121, 107);
            this.groupBoxTalle.Name = "groupBoxTalle";
            this.groupBoxTalle.Size = new System.Drawing.Size(214, 166);
            this.groupBoxTalle.TabIndex = 1;
            this.groupBoxTalle.TabStop = false;
            this.groupBoxTalle.Text = "Seleccione talle:";
            // 
            // rbTalleL
            // 
            this.rbTalleL.AutoSize = true;
            this.rbTalleL.Location = new System.Drawing.Point(15, 132);
            this.rbTalleL.Name = "rbTalleL";
            this.rbTalleL.Size = new System.Drawing.Size(113, 34);
            this.rbTalleL.TabIndex = 4;
            this.rbTalleL.TabStop = true;
            this.rbTalleL.Text = "L ($150)";
            this.rbTalleL.UseVisualStyleBackColor = true;
            // 
            // rbTalleM
            // 
            this.rbTalleM.AutoSize = true;
            this.rbTalleM.Location = new System.Drawing.Point(15, 83);
            this.rbTalleM.Name = "rbTalleM";
            this.rbTalleM.Size = new System.Drawing.Size(119, 34);
            this.rbTalleM.TabIndex = 3;
            this.rbTalleM.TabStop = true;
            this.rbTalleM.Text = "M ($100)";
            this.rbTalleM.UseVisualStyleBackColor = true;
            // 
            // rbTalleS
            // 
            this.rbTalleS.AutoSize = true;
            this.rbTalleS.Location = new System.Drawing.Point(15, 43);
            this.rbTalleS.Name = "rbTalleS";
            this.rbTalleS.Size = new System.Drawing.Size(99, 34);
            this.rbTalleS.TabIndex = 2;
            this.rbTalleS.TabStop = true;
            this.rbTalleS.Text = "S ($50)";
            this.rbTalleS.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.rbNegro);
            this.groupBoxColor.Controls.Add(this.rbBlanco);
            this.groupBoxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxColor.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.groupBoxColor.Location = new System.Drawing.Point(531, 107);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(214, 166);
            this.groupBoxColor.TabIndex = 2;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Seleccione color:";
            // 
            // rbNegro
            // 
            this.rbNegro.AutoSize = true;
            this.rbNegro.Location = new System.Drawing.Point(15, 105);
            this.rbNegro.Name = "rbNegro";
            this.rbNegro.Size = new System.Drawing.Size(82, 34);
            this.rbNegro.TabIndex = 3;
            this.rbNegro.TabStop = true;
            this.rbNegro.Text = "Negro";
            this.rbNegro.UseVisualStyleBackColor = true;
            // 
            // rbBlanco
            // 
            this.rbBlanco.AutoSize = true;
            this.rbBlanco.Location = new System.Drawing.Point(15, 43);
            this.rbBlanco.Name = "rbBlanco";
            this.rbBlanco.Size = new System.Drawing.Size(96, 34);
            this.rbBlanco.TabIndex = 2;
            this.rbBlanco.TabStop = true;
            this.rbBlanco.Text = "Blanco";
            this.rbBlanco.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(204)))), ((int)(((byte)(190)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.btnAgregar.Location = new System.Drawing.Point(360, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 63);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetalle.Font = new System.Drawing.Font("Segoe Script", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(54)))), ((int)(((byte)(51)))));
            this.txtDetalle.Location = new System.Drawing.Point(224, 375);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(464, 155);
            this.txtDetalle.TabIndex = 4;
            this.txtDetalle.Text = "Talle:\r\n\r\nColor:\r\n\r\nTotal: ";
            // 
            // txtboxTalle
            // 
            this.txtboxTalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.txtboxTalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxTalle.Location = new System.Drawing.Point(315, 381);
            this.txtboxTalle.Multiline = true;
            this.txtboxTalle.Name = "txtboxTalle";
            this.txtboxTalle.Size = new System.Drawing.Size(110, 30);
            this.txtboxTalle.TabIndex = 5;
            // 
            // txtboxcolor
            // 
            this.txtboxcolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.txtboxcolor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxcolor.Location = new System.Drawing.Point(315, 437);
            this.txtboxcolor.Multiline = true;
            this.txtboxcolor.Name = "txtboxcolor";
            this.txtboxcolor.Size = new System.Drawing.Size(110, 31);
            this.txtboxcolor.TabIndex = 6;
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.txtBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTotal.Location = new System.Drawing.Point(315, 492);
            this.txtBoxTotal.Multiline = true;
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.Size = new System.Drawing.Size(110, 29);
            this.txtBoxTotal.TabIndex = 7;
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.txtboxcolor);
            this.Controls.Add(this.txtboxTalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxTalle);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Size = new System.Drawing.Size(927, 561);
            this.groupBoxTalle.ResumeLayout(false);
            this.groupBoxTalle.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTalle;
        private System.Windows.Forms.RadioButton rbTalleL;
        private System.Windows.Forms.RadioButton rbTalleM;
        private System.Windows.Forms.RadioButton rbTalleS;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton rbNegro;
        private System.Windows.Forms.RadioButton rbBlanco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtboxTalle;
        private System.Windows.Forms.TextBox txtboxcolor;
        private System.Windows.Forms.TextBox txtBoxTotal;
    }
}
