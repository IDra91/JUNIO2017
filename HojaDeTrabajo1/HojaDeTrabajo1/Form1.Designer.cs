namespace HojaDeTrabajo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hipotenusa = new System.Windows.Forms.Button();
            this.inverso = new System.Windows.Forms.Button();
            this.vocal = new System.Windows.Forms.Button();
            this.regla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(131, 30);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(307, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(131, 72);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(307, 20);
            this.Txt2.TabIndex = 1;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(131, 110);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(307, 20);
            this.Txt3.TabIndex = 2;
            // 
            // Txt4
            // 
            this.Txt4.Location = new System.Drawing.Point(131, 153);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(307, 20);
            this.Txt4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dato1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dato2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dato3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado:";
            // 
            // hipotenusa
            // 
            this.hipotenusa.Location = new System.Drawing.Point(26, 202);
            this.hipotenusa.Name = "hipotenusa";
            this.hipotenusa.Size = new System.Drawing.Size(75, 23);
            this.hipotenusa.TabIndex = 8;
            this.hipotenusa.Text = "Hiportenusa";
            this.hipotenusa.UseVisualStyleBackColor = true;
            this.hipotenusa.Click += new System.EventHandler(this.button1_Click);
            // 
            // inverso
            // 
            this.inverso.Location = new System.Drawing.Point(117, 202);
            this.inverso.Name = "inverso";
            this.inverso.Size = new System.Drawing.Size(75, 23);
            this.inverso.TabIndex = 9;
            this.inverso.Text = "Inverso";
            this.inverso.UseVisualStyleBackColor = true;
            this.inverso.Click += new System.EventHandler(this.inverso_Click);
            // 
            // vocal
            // 
            this.vocal.Location = new System.Drawing.Point(207, 202);
            this.vocal.Name = "vocal";
            this.vocal.Size = new System.Drawing.Size(75, 23);
            this.vocal.TabIndex = 10;
            this.vocal.Text = "Vocales";
            this.vocal.UseVisualStyleBackColor = true;
            this.vocal.Click += new System.EventHandler(this.vocal_Click);
            // 
            // regla
            // 
            this.regla.Location = new System.Drawing.Point(305, 202);
            this.regla.Name = "regla";
            this.regla.Size = new System.Drawing.Size(75, 23);
            this.regla.TabIndex = 11;
            this.regla.Text = "Regla";
            this.regla.UseVisualStyleBackColor = true;
            this.regla.Click += new System.EventHandler(this.regla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 251);
            this.Controls.Add(this.regla);
            this.Controls.Add(this.vocal);
            this.Controls.Add(this.inverso);
            this.Controls.Add(this.hipotenusa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "Hoja de Trabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hipotenusa;
        private System.Windows.Forms.Button inverso;
        private System.Windows.Forms.Button vocal;
        private System.Windows.Forms.Button regla;
    }
}

