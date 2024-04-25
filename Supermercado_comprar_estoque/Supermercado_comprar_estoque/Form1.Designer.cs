namespace Supermercado_comprar_estoque
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
            this.txt_quantMaxEstoque = new System.Windows.Forms.TextBox();
            this.txt_quantEstoque = new System.Windows.Forms.TextBox();
            this.txt_nomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_enviarInfo = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_quantEstoque = new System.Windows.Forms.Label();
            this.lbl_quantComprar = new System.Windows.Forms.Label();
            this.btn_mostrarInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_quantMaxEstoque
            // 
            this.txt_quantMaxEstoque.Location = new System.Drawing.Point(10, 87);
            this.txt_quantMaxEstoque.Name = "txt_quantMaxEstoque";
            this.txt_quantMaxEstoque.Size = new System.Drawing.Size(253, 20);
            this.txt_quantMaxEstoque.TabIndex = 0;
            // 
            // txt_quantEstoque
            // 
            this.txt_quantEstoque.Location = new System.Drawing.Point(10, 136);
            this.txt_quantEstoque.Name = "txt_quantEstoque";
            this.txt_quantEstoque.Size = new System.Drawing.Size(253, 20);
            this.txt_quantEstoque.TabIndex = 1;
            // 
            // txt_nomeProduto
            // 
            this.txt_nomeProduto.Location = new System.Drawing.Point(11, 39);
            this.txt_nomeProduto.Name = "txt_nomeProduto";
            this.txt_nomeProduto.Size = new System.Drawing.Size(253, 20);
            this.txt_nomeProduto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade Maxima em Estoque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // btn_enviarInfo
            // 
            this.btn_enviarInfo.Location = new System.Drawing.Point(8, 175);
            this.btn_enviarInfo.Name = "btn_enviarInfo";
            this.btn_enviarInfo.Size = new System.Drawing.Size(108, 23);
            this.btn_enviarInfo.TabIndex = 6;
            this.btn_enviarInfo.Text = "enviar informações";
            this.btn_enviarInfo.UseVisualStyleBackColor = true;
            this.btn_enviarInfo.Click += new System.EventHandler(this.btn_enviarInfo_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(8, 27);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(92, 13);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "Nome do produto:";
            // 
            // lbl_quantEstoque
            // 
            this.lbl_quantEstoque.AutoSize = true;
            this.lbl_quantEstoque.Location = new System.Drawing.Point(8, 57);
            this.lbl_quantEstoque.Name = "lbl_quantEstoque";
            this.lbl_quantEstoque.Size = new System.Drawing.Size(123, 13);
            this.lbl_quantEstoque.TabIndex = 8;
            this.lbl_quantEstoque.Text = "Quantidade em estoque:";
            // 
            // lbl_quantComprar
            // 
            this.lbl_quantComprar.AutoSize = true;
            this.lbl_quantComprar.Location = new System.Drawing.Point(8, 86);
            this.lbl_quantComprar.Name = "lbl_quantComprar";
            this.lbl_quantComprar.Size = new System.Drawing.Size(107, 13);
            this.lbl_quantComprar.TabIndex = 9;
            this.lbl_quantComprar.Text = "Quantidade Comprar:";
            // 
            // btn_mostrarInfo
            // 
            this.btn_mostrarInfo.Location = new System.Drawing.Point(6, 115);
            this.btn_mostrarInfo.Name = "btn_mostrarInfo";
            this.btn_mostrarInfo.Size = new System.Drawing.Size(113, 23);
            this.btn_mostrarInfo.TabIndex = 11;
            this.btn_mostrarInfo.Text = "Mostrar Informações";
            this.btn_mostrarInfo.UseVisualStyleBackColor = true;
            this.btn_mostrarInfo.Click += new System.EventHandler(this.btn_mostrarInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enviarInfo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nomeProduto);
            this.groupBox1.Controls.Add(this.txt_quantEstoque);
            this.groupBox1.Controls.Add(this.txt_quantMaxEstoque);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviar Informações de estoque";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_mostrarInfo);
            this.groupBox2.Controls.Add(this.lbl_quantComprar);
            this.groupBox2.Controls.Add(this.lbl_quantEstoque);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Location = new System.Drawing.Point(2, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puxar Dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_quantMaxEstoque;
        private System.Windows.Forms.TextBox txt_quantEstoque;
        private System.Windows.Forms.TextBox txt_nomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_enviarInfo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_quantEstoque;
        private System.Windows.Forms.Label lbl_quantComprar;
        private System.Windows.Forms.Button btn_mostrarInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

