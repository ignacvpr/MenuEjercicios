namespace CursoClase1Csharp.Ejercicios
{
    partial class Ejercicio6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio6));
            this.lblEjercicio6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNro1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAC = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnporcentaje = new System.Windows.Forms.Button();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEjercicio6
            // 
            this.lblEjercicio6.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEjercicio6.ForeColor = System.Drawing.Color.White;
            this.lblEjercicio6.Location = new System.Drawing.Point(0, 0);
            this.lblEjercicio6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEjercicio6.Name = "lblEjercicio6";
            this.lblEjercicio6.Size = new System.Drawing.Size(158, 738);
            this.lblEjercicio6.TabIndex = 0;
            this.lblEjercicio6.Text = "Ejercicio 6";
            this.lblEjercicio6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CursoClase1Csharp.Properties.Resources._5cb0633d80f2cf201a4c3253;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblNro1);
            this.panel1.Controls.Add(this.lblOperacion);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.txtPantalla);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.panelnumerico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(158, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 738);
            this.panel1.TabIndex = 1;
            // 
            // lblNro1
            // 
            this.lblNro1.ForeColor = System.Drawing.Color.White;
            this.lblNro1.Location = new System.Drawing.Point(216, 106);
            this.lblNro1.Name = "lblNro1";
            this.lblNro1.Size = new System.Drawing.Size(251, 43);
            this.lblNro1.TabIndex = 6;
            this.lblNro1.Text = "0";
            this.lblNro1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNro1.Visible = false;
            // 
            // lblOperacion
            // 
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(158)))), ((int)(((byte)(9)))));
            this.lblOperacion.Location = new System.Drawing.Point(426, 166);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(41, 43);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOperacion.Visible = false;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = global::CursoClase1Csharp.Properties.Resources.copiar;
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.Location = new System.Drawing.Point(210, 233);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(50, 43);
            this.btnCopiar.TabIndex = 4;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.Color.Black;
            this.txtPantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPantalla.ForeColor = System.Drawing.Color.White;
            this.txtPantalla.Location = new System.Drawing.Point(286, 212);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.Size = new System.Drawing.Size(227, 58);
            this.txtPantalla.TabIndex = 3;
            this.txtPantalla.Text = "0";
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btndiv);
            this.flowLayoutPanel3.Controls.Add(this.btnmult);
            this.flowLayoutPanel3.Controls.Add(this.btnresta);
            this.flowLayoutPanel3.Controls.Add(this.btnsuma);
            this.flowLayoutPanel3.Controls.Add(this.btnigual);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(441, 307);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(72, 352);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btndiv
            // 
            this.btndiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndiv.BackgroundImage")));
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(3, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(65, 55);
            this.btndiv.TabIndex = 3;
            this.btndiv.Text = "÷";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmult.BackgroundImage")));
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(3, 64);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(65, 55);
            this.btnmult.TabIndex = 4;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresta.BackgroundImage")));
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(3, 125);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(65, 55);
            this.btnresta.TabIndex = 5;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsuma.BackgroundImage")));
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(3, 186);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(65, 55);
            this.btnsuma.TabIndex = 6;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnigual.BackgroundImage")));
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(3, 247);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(65, 55);
            this.btnigual.TabIndex = 7;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnAC);
            this.flowLayoutPanel2.Controls.Add(this.btnApagar);
            this.flowLayoutPanel2.Controls.Add(this.btnporcentaje);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(197, 304);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(238, 67);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnAC
            // 
            this.btnAC.BackgroundImage = global::CursoClase1Csharp.Properties.Resources.circulo1;
            this.btnAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAC.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAC.Location = new System.Drawing.Point(3, 3);
            this.btnAC.Name = "btnAC";
            this.btnAC.Size = new System.Drawing.Size(65, 55);
            this.btnAC.TabIndex = 0;
            this.btnAC.Text = "AC";
            this.btnAC.UseVisualStyleBackColor = true;
            this.btnAC.Click += new System.EventHandler(this.btnAC_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackgroundImage = global::CursoClase1Csharp.Properties.Resources.circulo1;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(74, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(58, 55);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Off";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnporcentaje
            // 
            this.btnporcentaje.BackgroundImage = global::CursoClase1Csharp.Properties.Resources.circulo1;
            this.btnporcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnporcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnporcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcentaje.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcentaje.Location = new System.Drawing.Point(138, 3);
            this.btnporcentaje.Name = "btnporcentaje";
            this.btnporcentaje.Size = new System.Drawing.Size(65, 55);
            this.btnporcentaje.TabIndex = 2;
            this.btnporcentaje.Text = "%";
            this.btnporcentaje.UseVisualStyleBackColor = true;
            this.btnporcentaje.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(210, 377);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(238, 282);
            this.panelnumerico.TabIndex = 0;
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEjercicio6);
            this.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Ejercicio6";
            this.Size = new System.Drawing.Size(1009, 738);
            this.Load += new System.EventHandler(this.Ejercicio6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEjercicio6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.Button btnAC;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnporcentaje;
        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Label lblNro1;
    }
}
