namespace WindowsFormsApp1
{
    partial class adminPanel
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
            this.btn_manageuser = new System.Windows.Forms.Button();
            this.button_fixed = new System.Windows.Forms.Button();
            this.btn_managebug = new System.Windows.Forms.Button();
            this.btn_assignbug = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_manageuser
            // 
            this.btn_manageuser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_manageuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manageuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_manageuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_manageuser.Location = new System.Drawing.Point(347, 1);
            this.btn_manageuser.Name = "btn_manageuser";
            this.btn_manageuser.Size = new System.Drawing.Size(346, 72);
            this.btn_manageuser.TabIndex = 0;
            this.btn_manageuser.Text = "Manage Users";
            this.btn_manageuser.UseVisualStyleBackColor = false;
            this.btn_manageuser.Click += new System.EventHandler(this.btn_manageuser_Click);
            // 
            // button_fixed
            // 
            this.button_fixed.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_fixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fixed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_fixed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_fixed.Location = new System.Drawing.Point(347, 313);
            this.button_fixed.Name = "button_fixed";
            this.button_fixed.Size = new System.Drawing.Size(346, 72);
            this.button_fixed.TabIndex = 0;
            this.button_fixed.Text = "Fixed Bugs";
            this.button_fixed.UseVisualStyleBackColor = false;
            this.button_fixed.Click += new System.EventHandler(this.button_fixed_Click);
            // 
            // btn_managebug
            // 
            this.btn_managebug.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_managebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_managebug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_managebug.Location = new System.Drawing.Point(347, 79);
            this.btn_managebug.Name = "btn_managebug";
            this.btn_managebug.Size = new System.Drawing.Size(346, 72);
            this.btn_managebug.TabIndex = 0;
            this.btn_managebug.Text = "Manage Bugs";
            this.btn_managebug.UseVisualStyleBackColor = false;
            this.btn_managebug.Click += new System.EventHandler(this.btn_managebug_Click);
            // 
            // btn_assignbug
            // 
            this.btn_assignbug.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_assignbug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assignbug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_assignbug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_assignbug.Location = new System.Drawing.Point(347, 157);
            this.btn_assignbug.Name = "btn_assignbug";
            this.btn_assignbug.Size = new System.Drawing.Size(346, 72);
            this.btn_assignbug.TabIndex = 0;
            this.btn_assignbug.Text = "Assign Bug";
            this.btn_assignbug.UseVisualStyleBackColor = false;
            this.btn_assignbug.Click += new System.EventHandler(this.btn_assignbug_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(347, 391);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(346, 72);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 476);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_manageuser);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btn_assignbug);
            this.Controls.Add(this.btn_managebug);
            this.Controls.Add(this.button_fixed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "adminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_manageuser;
        private System.Windows.Forms.Button button_fixed;
        private System.Windows.Forms.Button btn_managebug;
        private System.Windows.Forms.Button btn_assignbug;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}