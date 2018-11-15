namespace WindowsFormsApp1
{
    partial class ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_newPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_oldpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_reg = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 100);
            this.panel1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(85, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change Password";
            // 
            // txt_newPwd
            // 
            this.txt_newPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_newPwd.Location = new System.Drawing.Point(70, 267);
            this.txt_newPwd.Name = "txt_newPwd";
            this.txt_newPwd.Size = new System.Drawing.Size(272, 24);
            this.txt_newPwd.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(66, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "New Password";
            // 
            // txt_oldpwd
            // 
            this.txt_oldpwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_oldpwd.Location = new System.Drawing.Point(70, 188);
            this.txt_oldpwd.Name = "txt_oldpwd";
            this.txt_oldpwd.Size = new System.Drawing.Size(272, 24);
            this.txt_oldpwd.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(66, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Óld Password";
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_reg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reg.Location = new System.Drawing.Point(127, 328);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(137, 43);
            this.button_reg.TabIndex = 23;
            this.button_reg.Text = "Change";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_newPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_oldpwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_reg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_newPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_oldpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_reg;
    }
}