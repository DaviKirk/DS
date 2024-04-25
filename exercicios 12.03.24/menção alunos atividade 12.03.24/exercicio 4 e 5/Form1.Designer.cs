namespace exercicio_4_e_5
{
    partial class Form1
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
            this.txt_primeiranota = new System.Windows.Forms.TextBox();
            this.txt_segundanota = new System.Windows.Forms.TextBox();
            this.txt_terceiranota = new System.Windows.Forms.TextBox();
            this.txt_quartanota = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_primeiranota
            // 
            this.txt_primeiranota.Location = new System.Drawing.Point(12, 50);
            this.txt_primeiranota.Name = "txt_primeiranota";
            this.txt_primeiranota.Size = new System.Drawing.Size(100, 20);
            this.txt_primeiranota.TabIndex = 0;
            // 
            // txt_segundanota
            // 
            this.txt_segundanota.Location = new System.Drawing.Point(12, 106);
            this.txt_segundanota.Name = "txt_segundanota";
            this.txt_segundanota.Size = new System.Drawing.Size(100, 20);
            this.txt_segundanota.TabIndex = 1;
            // 
            // txt_terceiranota
            // 
            this.txt_terceiranota.Location = new System.Drawing.Point(12, 161);
            this.txt_terceiranota.Name = "txt_terceiranota";
            this.txt_terceiranota.Size = new System.Drawing.Size(100, 20);
            this.txt_terceiranota.TabIndex = 2;
            // 
            // txt_quartanota
            // 
            this.txt_quartanota.Location = new System.Drawing.Point(12, 211);
            this.txt_quartanota.Name = "txt_quartanota";
            this.txt_quartanota.Size = new System.Drawing.Size(100, 20);
            this.txt_quartanota.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(144, 161);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(118, 23);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular media";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "4° nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "1° nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "2° nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "3° nota";
            // 
            // txt_resultado
            // 
            this.txt_resultado.AutoSize = true;
            this.txt_resultado.Location = new System.Drawing.Point(194, 145);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(21, 13);
            this.txt_resultado.TabIndex = 11;
            this.txt_resultado.Text = "##";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_quartanota);
            this.Controls.Add(this.txt_terceiranota);
            this.Controls.Add(this.txt_segundanota);
            this.Controls.Add(this.txt_primeiranota);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_primeiranota;
        private System.Windows.Forms.TextBox txt_segundanota;
        private System.Windows.Forms.TextBox txt_terceiranota;
        private System.Windows.Forms.TextBox txt_quartanota;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt_resultado;
    }
}

