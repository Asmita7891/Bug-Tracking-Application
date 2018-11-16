namespace WindowsFormsApp1
{
    partial class userPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_changePwd = new System.Windows.Forms.Button();
            this.button_bugreport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserDashboard";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(286, 348);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(286, 110);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_about.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_about.Location = new System.Drawing.Point(286, 232);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(286, 110);
            this.button_about.TabIndex = 4;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_changePwd
            // 
            this.button_changePwd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_changePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_changePwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_changePwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_changePwd.Location = new System.Drawing.Point(286, 116);
            this.button_changePwd.Name = "button_changePwd";
            this.button_changePwd.Size = new System.Drawing.Size(286, 110);
            this.button_changePwd.TabIndex = 6;
            this.button_changePwd.Text = "Change Password";
            this.button_changePwd.UseVisualStyleBackColor = false;
            this.button_changePwd.Click += new System.EventHandler(this.button_changePwd_Click);
            // 
            // button_bugreport
            // 
            this.button_bugreport.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_bugreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bugreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_bugreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_bugreport.Location = new System.Drawing.Point(286, 0);
            this.button_bugreport.Name = "button_bugreport";
            this.button_bugreport.Size = new System.Drawing.Size(286, 110);
            this.button_bugreport.TabIndex = 7;
            this.button_bugreport.Text = "Bug Report";
            this.button_bugreport.UseVisualStyleBackColor = false;
            this.button_bugreport.Click += new System.EventHandler(this.button_bugreport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 472);
            this.panel1.TabIndex = 9;
            // 
            // userPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_changePwd);
            this.Controls.Add(this.button_bugreport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "userPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userPanel";
            this.Load += new System.EventHandler(this.userPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_changePwd;
        private System.Windows.Forms.Button button_bugreport;
        private System.Windows.Forms.Panel panel1;
    }
}