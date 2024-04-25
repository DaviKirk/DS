namespace exemploOperacaoForms
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
            this.somar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.subtrair = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.txt_numero3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // somar
            // 
            this.somar.Image = global::exemploOperacaoForms.Properties.Resources.plus_certo;
            this.somar.Location = new System.Drawing.Point(319, 31);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(75, 69);
            this.somar.TabIndex = 0;
            this.somar.Text = "somar";
            this.somar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.btn_somar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "digite o número 1°";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "digite o numero 2°";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "resultado";
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(30, 75);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(242, 20);
            this.txt_numero1.TabIndex = 4;
            this.txt_numero1.Click += new System.EventHandler(this.txt_numero1_click);
            this.txt_numero1.TextChanged += new System.EventHandler(this.txt_numero1_TextChanged);
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(30, 131);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(242, 20);
            this.txt_numero2.TabIndex = 5;
            this.txt_numero2.Click += new System.EventHandler(this.txt_numero2_click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(30, 230);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(242, 20);
            this.txt_resultado.TabIndex = 6;
            this.txt_resultado.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // subtrair
            // 
            this.subtrair.Image = global::exemploOperacaoForms.Properties.Resources.minus_gross_horizontal_straight_line_symbol_icon_icons_com_74137;
            this.subtrair.Location = new System.Drawing.Point(319, 106);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(75, 69);
            this.subtrair.TabIndex = 7;
            this.subtrair.Text = "subtrair";
            this.subtrair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.btn_subtrair);
            // 
            // div
            // 
            this.div.Image = global::exemploOperacaoForms.Properties.Resources.divisionsion;
            this.div.Location = new System.Drawing.Point(319, 256);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 69);
            this.div.TabIndex = 8;
            this.div.Text = "dividir";
            this.div.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.btn_dividir);
            // 
            // txt_numero3
            // 
            this.txt_numero3.Location = new System.Drawing.Point(30, 181);
            this.txt_numero3.Name = "txt_numero3";
            this.txt_numero3.Size = new System.Drawing.Size(242, 20);
            this.txt_numero3.TabIndex = 9;
            this.txt_numero3.Click += new System.EventHandler(this.txt_numero3_click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "digite o numero 3°";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mult
            // 
            this.mult.Image = global::exemploOperacaoForms.Properties.Resources.multiplicationsign_80855;
            this.mult.Location = new System.Drawing.Point(319, 181);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 69);
            this.mult.TabIndex = 11;
            this.mult.Text = "multiplicar";
            this.mult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.btn_multiplicar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::exemploOperacaoForms.Properties.Resources.fundo_calcu1;
            this.ClientSize = new System.Drawing.Size(427, 341);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_numero3);
            this.Controls.Add(this.div);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.somar);
            this.Name = "Form1";
            this.Text = "calculadora de soma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.TextBox txt_numero3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button mult;
    }
}

