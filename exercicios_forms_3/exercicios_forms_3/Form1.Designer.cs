namespace exercicios_forms_3
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
            this.txt_votosValidos = new System.Windows.Forms.TextBox();
            this.txt_votosBrancos = new System.Windows.Forms.TextBox();
            this.txt_votosNulos = new System.Windows.Forms.TextBox();
            this.text_votosValidos = new System.Windows.Forms.Label();
            this.text_votosBrancos = new System.Windows.Forms.Label();
            this.text_votosNulos = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_calcPorcentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_votosValidos
            // 
            this.txt_votosValidos.Location = new System.Drawing.Point(12, 57);
            this.txt_votosValidos.Name = "txt_votosValidos";
            this.txt_votosValidos.Size = new System.Drawing.Size(143, 20);
            this.txt_votosValidos.TabIndex = 0;
            // 
            // txt_votosBrancos
            // 
            this.txt_votosBrancos.Location = new System.Drawing.Point(12, 113);
            this.txt_votosBrancos.Name = "txt_votosBrancos";
            this.txt_votosBrancos.Size = new System.Drawing.Size(143, 20);
            this.txt_votosBrancos.TabIndex = 1;
            // 
            // txt_votosNulos
            // 
            this.txt_votosNulos.Location = new System.Drawing.Point(15, 174);
            this.txt_votosNulos.Name = "txt_votosNulos";
            this.txt_votosNulos.Size = new System.Drawing.Size(140, 20);
            this.txt_votosNulos.TabIndex = 2;
            // 
            // text_votosValidos
            // 
            this.text_votosValidos.AutoSize = true;
            this.text_votosValidos.Location = new System.Drawing.Point(12, 41);
            this.text_votosValidos.Name = "text_votosValidos";
            this.text_votosValidos.Size = new System.Drawing.Size(72, 13);
            this.text_votosValidos.TabIndex = 3;
            this.text_votosValidos.Text = "votos validos:";
            this.text_votosValidos.Click += new System.EventHandler(this.text_votosValidos_Click);
            // 
            // text_votosBrancos
            // 
            this.text_votosBrancos.AutoSize = true;
            this.text_votosBrancos.Location = new System.Drawing.Point(12, 97);
            this.text_votosBrancos.Name = "text_votosBrancos";
            this.text_votosBrancos.Size = new System.Drawing.Size(89, 13);
            this.text_votosBrancos.TabIndex = 4;
            this.text_votosBrancos.Text = "votos em branco:";
            // 
            // text_votosNulos
            // 
            this.text_votosNulos.AutoSize = true;
            this.text_votosNulos.Location = new System.Drawing.Point(12, 158);
            this.text_votosNulos.Name = "text_votosNulos";
            this.text_votosNulos.Size = new System.Drawing.Size(64, 13);
            this.text_votosNulos.TabIndex = 5;
            this.text_votosNulos.Text = "votos nulos:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(210, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(106, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(210, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 20);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(210, 174);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "digite a quantidade de votos:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calcPorcentagem
            // 
            this.btn_calcPorcentagem.Location = new System.Drawing.Point(15, 226);
            this.btn_calcPorcentagem.Name = "btn_calcPorcentagem";
            this.btn_calcPorcentagem.Size = new System.Drawing.Size(75, 23);
            this.btn_calcPorcentagem.TabIndex = 10;
            this.btn_calcPorcentagem.Text = "calcular %";
            this.btn_calcPorcentagem.UseVisualStyleBackColor = true;
            this.btn_calcPorcentagem.Click += new System.EventHandler(this.btn_calcPorcentagem_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 261);
            this.Controls.Add(this.btn_calcPorcentagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.text_votosNulos);
            this.Controls.Add(this.text_votosBrancos);
            this.Controls.Add(this.text_votosValidos);
            this.Controls.Add(this.txt_votosNulos);
            this.Controls.Add(this.txt_votosBrancos);
            this.Controls.Add(this.txt_votosValidos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_votosValidos;
        private System.Windows.Forms.TextBox txt_votosBrancos;
        private System.Windows.Forms.TextBox txt_votosNulos;
        private System.Windows.Forms.Label text_votosValidos;
        private System.Windows.Forms.Label text_votosBrancos;
        private System.Windows.Forms.Label text_votosNulos;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_calcPorcentagem;
    }
}

