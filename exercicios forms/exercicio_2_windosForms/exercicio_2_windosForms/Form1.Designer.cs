namespace exercicio_2_windosForms
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
            this.txt_anos = new System.Windows.Forms.TextBox();
            this.text_resultado = new System.Windows.Forms.TextBox();
            this.converter_btn = new System.Windows.Forms.Button();
            this.explicacao1 = new System.Windows.Forms.Label();
            this.explicacao_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_anos
            // 
            this.txt_anos.Location = new System.Drawing.Point(39, 69);
            this.txt_anos.Name = "txt_anos";
            this.txt_anos.Size = new System.Drawing.Size(201, 20);
            this.txt_anos.TabIndex = 0;
            this.txt_anos.Click += new System.EventHandler(this.click_anos);
            this.txt_anos.TextChanged += new System.EventHandler(this.txt_anos_TextChanged);
            // 
            // text_resultado
            // 
            this.text_resultado.Location = new System.Drawing.Point(39, 140);
            this.text_resultado.Name = "text_resultado";
            this.text_resultado.ReadOnly = true;
            this.text_resultado.Size = new System.Drawing.Size(201, 20);
            this.text_resultado.TabIndex = 1;
            this.text_resultado.Click += new System.EventHandler(this.text_dias);
            // 
            // converter_btn
            // 
            this.converter_btn.Location = new System.Drawing.Point(94, 166);
            this.converter_btn.Name = "converter_btn";
            this.converter_btn.Size = new System.Drawing.Size(75, 23);
            this.converter_btn.TabIndex = 2;
            this.converter_btn.Text = "Converter";
            this.converter_btn.UseVisualStyleBackColor = true;
            this.converter_btn.Click += new System.EventHandler(this.converter_Click);
            // 
            // explicacao1
            // 
            this.explicacao1.AutoSize = true;
            this.explicacao1.Location = new System.Drawing.Point(36, 43);
            this.explicacao1.Name = "explicacao1";
            this.explicacao1.Size = new System.Drawing.Size(154, 13);
            this.explicacao1.TabIndex = 3;
            this.explicacao1.Text = "escreva a quantidade de anos:";
            // 
            // explicacao_resultado
            // 
            this.explicacao_resultado.AutoSize = true;
            this.explicacao_resultado.Location = new System.Drawing.Point(36, 124);
            this.explicacao_resultado.Name = "explicacao_resultado";
            this.explicacao_resultado.Size = new System.Drawing.Size(99, 13);
            this.explicacao_resultado.TabIndex = 4;
            this.explicacao_resultado.Text = "convertido em dias:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.explicacao_resultado);
            this.Controls.Add(this.explicacao1);
            this.Controls.Add(this.converter_btn);
            this.Controls.Add(this.text_resultado);
            this.Controls.Add(this.txt_anos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_anos;
        private System.Windows.Forms.TextBox text_resultado;
        private System.Windows.Forms.Button converter_btn;
        private System.Windows.Forms.Label explicacao1;
        private System.Windows.Forms.Label explicacao_resultado;
    }
}

