namespace exemplo_if_else
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btn_escolha = new System.Windows.Forms.Button();
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.rdb_noite = new System.Windows.Forms.RadioButton();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_escolha
            // 
            this.btn_escolha.Location = new System.Drawing.Point(162, 94);
            this.btn_escolha.Name = "btn_escolha";
            this.btn_escolha.Size = new System.Drawing.Size(92, 23);
            this.btn_escolha.TabIndex = 0;
            this.btn_escolha.Text = "menssagem";
            this.btn_escolha.UseVisualStyleBackColor = true;
            this.btn_escolha.Click += new System.EventHandler(this.btn_escolha_Click);
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(30, 39);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(58, 17);
            this.rdb_manha.TabIndex = 1;
            this.rdb_manha.TabStop = true;
            this.rdb_manha.Text = "Manhã";
            this.rdb_manha.UseVisualStyleBackColor = true;
            this.rdb_manha.CheckedChanged += new System.EventHandler(this.rdb_manha_CheckedChanged);
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(30, 94);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_tarde.TabIndex = 2;
            this.rdb_tarde.TabStop = true;
            this.rdb_tarde.Text = "Tarde";
            this.rdb_tarde.UseVisualStyleBackColor = true;
            this.rdb_tarde.CheckedChanged += new System.EventHandler(this.rdb_tarde_CheckedChanged);
            // 
            // rdb_noite
            // 
            this.rdb_noite.AutoSize = true;
            this.rdb_noite.Location = new System.Drawing.Point(30, 154);
            this.rdb_noite.Name = "rdb_noite";
            this.rdb_noite.Size = new System.Drawing.Size(50, 17);
            this.rdb_noite.TabIndex = 3;
            this.rdb_noite.TabStop = true;
            this.rdb_noite.Text = "Noite";
            this.rdb_noite.UseVisualStyleBackColor = true;
            this.rdb_noite.CheckedChanged += new System.EventHandler(this.rdb_noite_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_noite);
            this.groupBox1.Controls.Add(this.rdb_tarde);
            this.groupBox1.Controls.Add(this.rdb_manha);
            this.groupBox1.Controls.Add(this.btn_escolha);
            this.groupBox1.Location = new System.Drawing.Point(69, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Periodo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btn_escolha;
        private System.Windows.Forms.RadioButton rdb_manha;
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.RadioButton rdb_noite;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

