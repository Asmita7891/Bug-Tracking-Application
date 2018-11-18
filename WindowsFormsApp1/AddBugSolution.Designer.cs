namespace WindowsFormsApp1
{
    partial class AddBugSolution
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
            this.txtboxProject = new System.Windows.Forms.TextBox();
            this.txt_bugtitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bugsol = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtbox_desc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_method = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.txtBox_bugID = new System.Windows.Forms.TextBox();
            this.lbl_project = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_bugDescription = new System.Windows.Forms.Label();
            this.lbl_bugTitle = new System.Windows.Forms.Label();
            this.lbl_addBug = new System.Windows.Forms.Label();
            this.lbl_bugID = new System.Windows.Forms.Label();
            this.cmbBox_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.solvedate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_reportDate = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.button_cls = new System.Windows.Forms.Button();
            this.dgv_sol = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sol)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxProject
            // 
            this.txtboxProject.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtboxProject.Location = new System.Drawing.Point(209, 31);
            this.txtboxProject.Name = "txtboxProject";
            this.txtboxProject.ReadOnly = true;
            this.txtboxProject.Size = new System.Drawing.Size(309, 24);
            this.txtboxProject.TabIndex = 65;
            // 
            // txt_bugtitle
            // 
            this.txt_bugtitle.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bugtitle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_bugtitle.Location = new System.Drawing.Point(209, 61);
            this.txt_bugtitle.Name = "txt_bugtitle";
            this.txt_bugtitle.ReadOnly = true;
            this.txt_bugtitle.Size = new System.Drawing.Size(309, 24);
            this.txt_bugtitle.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(26, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Bug Title";
            // 
            // txt_bugsol
            // 
            this.txt_bugsol.BackColor = System.Drawing.SystemColors.Control;
            this.txt_bugsol.Location = new System.Drawing.Point(743, 96);
            this.txt_bugsol.Multiline = true;
            this.txt_bugsol.Name = "txt_bugsol";
            this.txt_bugsol.Size = new System.Drawing.Size(309, 129);
            this.txt_bugsol.TabIndex = 62;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(209, 91);
            this.txtdes.Multiline = true;
            this.txtdes.Name = "txtdes";
            this.txtdes.ReadOnly = true;
            this.txtdes.Size = new System.Drawing.Size(309, 134);
            this.txtdes.TabIndex = 61;
            // 
            // txtbox_desc
            // 
            this.txtbox_desc.AutoSize = true;
            this.txtbox_desc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtbox_desc.Location = new System.Drawing.Point(26, 92);
            this.txtbox_desc.Name = "txtbox_desc";
            this.txtbox_desc.Size = new System.Drawing.Size(89, 21);
            this.txtbox_desc.TabIndex = 60;
            this.txtbox_desc.Text = "Error code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(560, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 59;
            this.label4.Text = "Solved code";
            // 
            // txt_method
            // 
            this.txt_method.BackColor = System.Drawing.SystemColors.Control;
            this.txt_method.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_method.Location = new System.Drawing.Point(744, 32);
            this.txt_method.Name = "txt_method";
            this.txt_method.Size = new System.Drawing.Size(309, 27);
            this.txt_method.TabIndex = 57;
            // 
            // txt_line
            // 
            this.txt_line.BackColor = System.Drawing.SystemColors.Control;
            this.txt_line.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_line.Location = new System.Drawing.Point(744, 65);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(309, 24);
            this.txt_line.TabIndex = 56;
            // 
            // txt_class
            // 
            this.txt_class.BackColor = System.Drawing.SystemColors.Control;
            this.txt_class.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txt_class.Location = new System.Drawing.Point(744, 2);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(309, 24);
            this.txt_class.TabIndex = 55;
            // 
            // txtBox_bugID
            // 
            this.txtBox_bugID.Location = new System.Drawing.Point(209, 5);
            this.txtBox_bugID.Name = "txtBox_bugID";
            this.txtBox_bugID.ReadOnly = true;
            this.txtBox_bugID.Size = new System.Drawing.Size(136, 20);
            this.txtBox_bugID.TabIndex = 54;
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_project.Location = new System.Drawing.Point(26, 34);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(64, 21);
            this.lbl_project.TabIndex = 52;
            this.lbl_project.Text = "Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 50;
            this.label2.Text = "Line no.";
            // 
            // lbl_bugDescription
            // 
            this.lbl_bugDescription.AutoSize = true;
            this.lbl_bugDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugDescription.Location = new System.Drawing.Point(560, 34);
            this.lbl_bugDescription.Name = "lbl_bugDescription";
            this.lbl_bugDescription.Size = new System.Drawing.Size(73, 21);
            this.lbl_bugDescription.TabIndex = 49;
            this.lbl_bugDescription.Text = "Method";
            // 
            // lbl_bugTitle
            // 
            this.lbl_bugTitle.AutoSize = true;
            this.lbl_bugTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugTitle.Location = new System.Drawing.Point(560, 2);
            this.lbl_bugTitle.Name = "lbl_bugTitle";
            this.lbl_bugTitle.Size = new System.Drawing.Size(49, 21);
            this.lbl_bugTitle.TabIndex = 48;
            this.lbl_bugTitle.Text = "Class";
            // 
            // lbl_addBug
            // 
            this.lbl_addBug.AutoSize = true;
            this.lbl_addBug.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_addBug.Location = new System.Drawing.Point(357, -26);
            this.lbl_addBug.Name = "lbl_addBug";
            this.lbl_addBug.Size = new System.Drawing.Size(193, 26);
            this.lbl_addBug.TabIndex = 53;
            this.lbl_addBug.Text = "Add Bug Solution";
            // 
            // lbl_bugID
            // 
            this.lbl_bugID.AutoSize = true;
            this.lbl_bugID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bugID.Location = new System.Drawing.Point(26, 5);
            this.lbl_bugID.Name = "lbl_bugID";
            this.lbl_bugID.Size = new System.Drawing.Size(61, 21);
            this.lbl_bugID.TabIndex = 47;
            this.lbl_bugID.Text = "Bug ID";
            // 
            // cmbBox_status
            // 
            this.cmbBox_status.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbBox_status.FormattingEnabled = true;
            this.cmbBox_status.Items.AddRange(new object[] {
            "active",
            "solved"});
            this.cmbBox_status.Location = new System.Drawing.Point(209, 261);
            this.cmbBox_status.Name = "cmbBox_status";
            this.cmbBox_status.Size = new System.Drawing.Size(309, 25);
            this.cmbBox_status.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(28, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "Status";
            // 
            // reportDate
            // 
            this.reportDate.Checked = false;
            this.reportDate.CustomFormat = "yyyy-MM-dd";
            this.reportDate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.reportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reportDate.Location = new System.Drawing.Point(209, 231);
            this.reportDate.Name = "reportDate";
            this.reportDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reportDate.Size = new System.Drawing.Size(200, 24);
            this.reportDate.TabIndex = 68;
            this.reportDate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // solvedate
            // 
            this.solvedate.Checked = false;
            this.solvedate.CustomFormat = "yyyy-MM-dd";
            this.solvedate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.solvedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.solvedate.Location = new System.Drawing.Point(744, 232);
            this.solvedate.Name = "solvedate";
            this.solvedate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.solvedate.Size = new System.Drawing.Size(200, 24);
            this.solvedate.TabIndex = 69;
            this.solvedate.Value = new System.DateTime(2018, 11, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Report Date\r\n";
            // 
            // lbl_reportDate
            // 
            this.lbl_reportDate.AutoSize = true;
            this.lbl_reportDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportDate.Location = new System.Drawing.Point(561, 235);
            this.lbl_reportDate.Name = "lbl_reportDate";
            this.lbl_reportDate.Size = new System.Drawing.Size(94, 21);
            this.lbl_reportDate.TabIndex = 67;
            this.lbl_reportDate.Text = "Solve date";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_save.Location = new System.Drawing.Point(891, 265);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 72;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button_cls
            // 
            this.button_cls.BackColor = System.Drawing.Color.Red;
            this.button_cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cls.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_cls.Location = new System.Drawing.Point(977, 265);
            this.button_cls.Name = "button_cls";
            this.button_cls.Size = new System.Drawing.Size(75, 34);
            this.button_cls.TabIndex = 73;
            this.button_cls.Text = "Close";
            this.button_cls.UseVisualStyleBackColor = false;
            this.button_cls.Click += new System.EventHandler(this.button_cls_Click);
            // 
            // dgv_sol
            // 
            this.dgv_sol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sol.Location = new System.Drawing.Point(3, 305);
            this.dgv_sol.Name = "dgv_sol";
            this.dgv_sol.Size = new System.Drawing.Size(1058, 290);
            this.dgv_sol.TabIndex = 74;
            this.dgv_sol.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_sol_RowHeaderMouseClick);
            // 
            // AddBugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 599);
            this.Controls.Add(this.dgv_sol);
            this.Controls.Add(this.button_cls);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmbBox_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportDate);
            this.Controls.Add(this.solvedate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_reportDate);
            this.Controls.Add(this.txtboxProject);
            this.Controls.Add(this.txt_bugtitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_bugsol);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtbox_desc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_method);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.txtBox_bugID);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_bugDescription);
            this.Controls.Add(this.lbl_bugTitle);
            this.Controls.Add(this.lbl_addBug);
            this.Controls.Add(this.lbl_bugID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBugSolution";
            this.Text = "AddBugSolution";
            this.Load += new System.EventHandler(this.AddBugSolution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxProject;
        private System.Windows.Forms.TextBox txt_bugtitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bugsol;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.Label txtbox_desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_method;
        private System.Windows.Forms.TextBox txt_line;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.TextBox txtBox_bugID;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_bugDescription;
        private System.Windows.Forms.Label lbl_bugTitle;
        private System.Windows.Forms.Label lbl_addBug;
        private System.Windows.Forms.Label lbl_bugID;
        private System.Windows.Forms.ComboBox cmbBox_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.DateTimePicker solvedate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_reportDate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button_cls;
        private System.Windows.Forms.DataGridView dgv_sol;
    }
}