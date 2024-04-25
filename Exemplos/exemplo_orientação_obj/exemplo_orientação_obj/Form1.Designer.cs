namespace exemplo_orientação_obj
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
            this.btn_somar = new System.Windows.Forms.Button();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_resu = new System.Windows.Forms.TextBox();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(3, 226);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(56, 23);
            this.btn_somar.TabIndex = 0;
            this.btn_somar.Text = "somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(88, 123);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 1;
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(88, 47);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1° Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2° Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // txt_resu
            // 
            this.txt_resu.Location = new System.Drawing.Point(88, 162);
            this.txt_resu.Name = "txt_resu";
            this.txt_resu.ReadOnly = true;
            this.txt_resu.Size = new System.Drawing.Size(100, 20);
            this.txt_resu.TabIndex = 7;
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.Location = new System.Drawing.Point(65, 226);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(66, 23);
            this.btn_subtracao.TabIndex = 8;
            this.btn_subtracao.Text = "subtração";
            this.btn_subtracao.UseVisualStyleBackColor = true;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(137, 226);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(77, 23);
            this.btn_multi.TabIndex = 9;
            this.btn_multi.Text = "multiplicação";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.btn_multi_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(220, 226);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(56, 23);
            this.btn_divisao.TabIndex = 10;
            this.btn_divisao.Text = "divisão";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.txt_resu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.btn_somar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_resu;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divisao;
    }
}

