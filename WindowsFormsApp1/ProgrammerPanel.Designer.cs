namespace WindowsFormsApp1
{
    partial class ProgrammerPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_assign = new System.Windows.Forms.Button();
            this.btn_changepwd = new System.Windows.Forms.Button();
            this.button_lgout = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 458);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dashboard";
            // 
            // button_assign
            // 
            this.button_assign.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_assign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_assign.Location = new System.Drawing.Point(290, 115);
            this.button_assign.Name = "button_assign";
            this.button_assign.Size = new System.Drawing.Size(277, 110);
            this.button_assign.TabIndex = 9;
            this.button_assign.Text = "AssignedBug";
            this.button_assign.UseVisualStyleBackColor = false;
            this.button_assign.Click += new System.EventHandler(this.button_assign_Click);
            // 
            // btn_changepwd
            // 
            this.btn_changepwd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_changepwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changepwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_changepwd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_changepwd.Location = new System.Drawing.Point(290, 231);
            this.btn_changepwd.Name = "btn_changepwd";
            this.btn_changepwd.Size = new System.Drawing.Size(277, 110);
            this.btn_changepwd.TabIndex = 10;
            this.btn_changepwd.Text = "Change Password";
            this.btn_changepwd.UseVisualStyleBackColor = false;
            this.btn_changepwd.Click += new System.EventHandler(this.btn_changepwd_Click);
            // 
            // button_lgout
            // 
            this.button_lgout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_lgout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lgout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_lgout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_lgout.Location = new System.Drawing.Point(290, 347);
            this.button_lgout.Name = "button_lgout";
            this.button_lgout.Size = new System.Drawing.Size(277, 110);
            this.button_lgout.TabIndex = 11;
            this.button_lgout.Text = "Logout";
            this.button_lgout.UseVisualStyleBackColor = false;
            this.button_lgout.Click += new System.EventHandler(this.button_lgout_Click);
            // 
            // button_about
            // 
            this.button_about.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_about.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_about.Location = new System.Drawing.Point(290, -1);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(277, 110);
            this.button_about.TabIndex = 8;
            this.button_about.Text = "Add Bug Solution";
            this.button_about.UseVisualStyleBackColor = false;
            this.button_about.Click += new System.EventHandler(this.button_bugsol_Click);
            // 
            // ProgrammerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 456);
            this.Controls.Add(this.button_lgout);
            this.Controls.Add(this.btn_changepwd);
            this.Controls.Add(this.button_assign);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgrammerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgrammerPanel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_assign;
        private System.Windows.Forms.Button btn_changepwd;
        private System.Windows.Forms.Button button_lgout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_about;
    }
}