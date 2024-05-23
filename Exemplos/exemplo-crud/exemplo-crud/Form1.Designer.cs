namespace exemplo_crud
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_exluir = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(17, 41);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(66, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(91, 41);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(135, 20);
            this.txt_sobrenome.TabIndex = 1;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(17, 93);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(209, 20);
            this.txt_cpf.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(17, 141);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(85, 20);
            this.txt_id.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sobrenomes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exluir);
            this.groupBox1.Controls.Add(this.btn_consulta);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 208);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestão colaborador";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // btn_exluir
            // 
            this.btn_exluir.Image = global::exemplo_crud.Properties.Resources.lixeira;
            this.btn_exluir.Location = new System.Drawing.Point(377, 119);
            this.btn_exluir.Name = "btn_exluir";
            this.btn_exluir.Size = new System.Drawing.Size(107, 50);
            this.btn_exluir.TabIndex = 10;
            this.btn_exluir.Text = "Excluir";
            this.btn_exluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exluir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_exluir.UseVisualStyleBackColor = true;
            this.btn_exluir.Click += new System.EventHandler(this.btn_exluir_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Image = global::exemplo_crud.Properties.Resources.lupa;
            this.btn_consulta.Location = new System.Drawing.Point(248, 119);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(107, 50);
            this.btn_consulta.TabIndex = 9;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Image = global::exemplo_crud.Properties.Resources.diskette;
            this.btn_salvar.Location = new System.Drawing.Point(119, 119);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(107, 50);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btn_exluir;
    }
}

