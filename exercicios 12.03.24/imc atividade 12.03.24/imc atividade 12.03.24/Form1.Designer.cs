namespace imc_atividade_12._03._24
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
            this.btn_IMCcalc = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_box1 = new System.Windows.Forms.TextBox();
            this.txt_box2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_IMCcalc
            // 
            this.btn_IMCcalc.Location = new System.Drawing.Point(79, 221);
            this.btn_IMCcalc.Name = "btn_IMCcalc";
            this.btn_IMCcalc.Size = new System.Drawing.Size(115, 28);
            this.btn_IMCcalc.TabIndex = 0;
            this.btn_IMCcalc.Text = "calc IMC";
            this.btn_IMCcalc.UseVisualStyleBackColor = true;
            this.btn_IMCcalc.Click += new System.EventHandler(this.btn_IMCcalc_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(97, 195);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(73, 13);
            this.lbl_resultado.TabIndex = 1;
            this.lbl_resultado.Text = "resultado aqui";
            this.lbl_resultado.Click += new System.EventHandler(this.lbl_resultado_Click);
            // 
            // txt_box1
            // 
            this.txt_box1.Location = new System.Drawing.Point(54, 55);
            this.txt_box1.Name = "txt_box1";
            this.txt_box1.Size = new System.Drawing.Size(169, 20);
            this.txt_box1.TabIndex = 2;
            // 
            // txt_box2
            // 
            this.txt_box2.Location = new System.Drawing.Point(54, 124);
            this.txt_box2.Name = "txt_box2";
            this.txt_box2.Size = new System.Drawing.Size(169, 20);
            this.txt_box2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Peso";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Altura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_box2);
            this.Controls.Add(this.txt_box1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_IMCcalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_IMCcalc;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_box1;
        private System.Windows.Forms.TextBox txt_box2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

