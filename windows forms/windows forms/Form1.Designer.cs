namespace windows_forms
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_play.Location = new System.Drawing.Point(77, 157);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(181, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "dar o plai no gaimi\'s";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click_1);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_settings.Location = new System.Drawing.Point(77, 186);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(181, 23);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "opitiouns das setingues do gaime\'s";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(353, 332);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_settings;
    }
}

