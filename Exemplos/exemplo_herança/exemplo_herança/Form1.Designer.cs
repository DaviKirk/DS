namespace exemplo_herança
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
            this.btn_armazenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_RG = new System.Windows.Forms.Label();
            this.lbl_cartao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_armazenar
            // 
            this.btn_armazenar.Location = new System.Drawing.Point(178, 54);
            this.btn_armazenar.Name = "btn_armazenar";
            this.btn_armazenar.Size = new System.Drawing.Size(117, 98);
            this.btn_armazenar.TabIndex = 0;
            this.btn_armazenar.Text = "Armazenar e Desmonstrar";
            this.btn_armazenar.UseVisualStyleBackColor = true;
            this.btn_armazenar.Click += new System.EventHandler(this.btn_armazenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "RG:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cartão";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(53, 51);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(53, 94);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(100, 20);
            this.txt_RG.TabIndex = 5;
            this.txt_RG.TextChanged += new System.EventHandler(this.txt_RG_TextChanged);
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(53, 136);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(100, 20);
            this.txt_cartao.TabIndex = 6;
            this.txt_cartao.TextChanged += new System.EventHandler(this.txt_cartao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Exibir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RG:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cartão:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(53, 243);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 13);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "lbl_nome";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // lbl_RG
            // 
            this.lbl_RG.AutoSize = true;
            this.lbl_RG.Location = new System.Drawing.Point(53, 277);
            this.lbl_RG.Name = "lbl_RG";
            this.lbl_RG.Size = new System.Drawing.Size(39, 13);
            this.lbl_RG.TabIndex = 12;
            this.lbl_RG.Text = "lbl_RG";
            this.lbl_RG.Click += new System.EventHandler(this.lbl_RG_Click);
            // 
            // lbl_cartao
            // 
            this.lbl_cartao.AutoSize = true;
            this.lbl_cartao.Location = new System.Drawing.Point(53, 308);
            this.lbl_cartao.Name = "lbl_cartao";
            this.lbl_cartao.Size = new System.Drawing.Size(53, 13);
            this.lbl_cartao.TabIndex = 13;
            this.lbl_cartao.Text = "lbl_cartao";
            this.lbl_cartao.Click += new System.EventHandler(this.lbl_cartao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 350);
            this.Controls.Add(this.lbl_cartao);
            this.Controls.Add(this.lbl_RG);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cartao);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_armazenar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_armazenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_RG;
        private System.Windows.Forms.Label lbl_cartao;
    }
}

