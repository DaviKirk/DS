namespace Media_Final_Orientado_Obj
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
            this.lbl_resu = new System.Windows.Forms.Label();
            this.btn_somaMedia = new System.Windows.Forms.Button();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_nota4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_resu
            // 
            this.lbl_resu.AutoSize = true;
            this.lbl_resu.Location = new System.Drawing.Point(128, 240);
            this.lbl_resu.Name = "lbl_resu";
            this.lbl_resu.Size = new System.Drawing.Size(19, 13);
            this.lbl_resu.TabIndex = 0;
            this.lbl_resu.Text = "00";
            // 
            // btn_somaMedia
            // 
            this.btn_somaMedia.Location = new System.Drawing.Point(104, 256);
            this.btn_somaMedia.Name = "btn_somaMedia";
            this.btn_somaMedia.Size = new System.Drawing.Size(75, 23);
            this.btn_somaMedia.TabIndex = 1;
            this.btn_somaMedia.Text = "somar media";
            this.btn_somaMedia.UseVisualStyleBackColor = true;
            this.btn_somaMedia.Click += new System.EventHandler(this.btn_somaMedia_Click);
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(83, 64);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(125, 20);
            this.txt_nota1.TabIndex = 2;
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(83, 111);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(125, 20);
            this.txt_nota2.TabIndex = 3;
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(83, 161);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(125, 20);
            this.txt_nota3.TabIndex = 4;
            // 
            // txt_nota4
            // 
            this.txt_nota4.Location = new System.Drawing.Point(83, 206);
            this.txt_nota4.Name = "txt_nota4";
            this.txt_nota4.Size = new System.Drawing.Size(125, 20);
            this.txt_nota4.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "digite a 4° nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "digite a 1° nota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "digite a 3° nota:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "digite a 2° nota:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 314);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nota4);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.txt_nota1);
            this.Controls.Add(this.btn_somaMedia);
            this.Controls.Add(this.lbl_resu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_resu;
        private System.Windows.Forms.Button btn_somaMedia;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_nota4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

